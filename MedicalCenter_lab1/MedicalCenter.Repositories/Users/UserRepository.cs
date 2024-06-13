using MedicalCenter.Core.Context;
using MedicalCenter.Core.Entities;
using MedicalCenter.Repositories.Appointments;
using MedicalCenter.Repositories.Common;
using MedicalCenter.Repositories.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCenter.Repositories.Users
{
    public class UserRepository : Repository<User, Guid>, IUserRepository
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;

        public UserRepository(ProjectContext ctx,
            UserManager<User> userManager,
            RoleManager<IdentityRole<Guid>> roleManager) : base(ctx)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IEnumerable<UserListItemModel>> GetAllWithRolesAsync()
        {
            var list = new List<UserListItemModel>();

            foreach (var user in await _ctx.Users.ToListAsync())
            {
                var userModel = new UserListItemModel
                {
                    Id = user.Id,
                    Email = user.Email,
                    FullName = user.FullName,
                    Photo = user.Photo,
                    Age = user.Age,
                    DateOfBirth = user.DateOfBirth,
                    Address = user.Address,
                    PhoneNumber = user.PhoneNumber,
                    Roles = new List<IdentityRole<Guid>>()
                };

                foreach (var role in await _userManager.GetRolesAsync(user))
                {
                    userModel.Roles.Add(await _ctx.Roles.FirstAsync(x => x.Name.ToLower() == role.ToLower()));
                }

                list.Add(userModel);
            }

            return list;
        }
        public async Task<UserListItemModel> GetOneWithRolesAsync(Guid id)
        {
            var user = await _ctx.Users.FirstAsync(x => x.Id == id);

            var userModel = new UserListItemModel
            {
                Id = user.Id,
                Email = user.Email,
                FullName = user.FullName,
                Roles = new List<IdentityRole<Guid>>()
            };

            foreach (var role in await _userManager.GetRolesAsync(user))
            {
                userModel.Roles.Add(await _ctx.Roles.FirstAsync(x => x.Name.ToLower() == role.ToLower()));
            }

            return userModel;
        }
        public async Task<IEnumerable<IdentityRole<Guid>>> GetRolesAsync()
        {
            return await _ctx.Roles.ToListAsync();
        }

        public async Task<bool> CheckUser(Guid id)
        {
            var user = _ctx.Users.Find(id);
            var roles = await _userManager.GetRolesAsync(user);
            return roles.All(x => x != "Admin");
        }
        public async Task DeleteUser(Guid id)
        {
            var user = _ctx.Users.Find(id);

            if (await CheckUser(id))
            {
                if ((await _userManager.GetRolesAsync(user)).Any())
                {
                    await _userManager.RemoveFromRolesAsync(user, await _userManager.GetRolesAsync(user));
                }

                await _userManager.DeleteAsync(user);
            }
        }
        public async Task<IEnumerable<User>> GetUsersByRoleAsync(string roleName)
        {
            var role = await _roleManager.Roles.FirstOrDefaultAsync(r => r.Name == roleName);
            if (role == null)
            {
                return new List<User>();
            }

            var usersInRole = await _userManager.GetUsersInRoleAsync(roleName);
            return usersInRole;
        }
        public async Task<IEnumerable<DoctorPopularityModel>> GetDoctorPopularityAsync()
        {
            return await _ctx.Appointments
                .GroupBy(a => a.DoctorId)
                .Select(g => new DoctorPopularityModel
                {
                    DoctorId = g.Key ?? Guid.Empty,
                    DoctorName = _ctx.Users.Where(u => u.Id == g.Key).Select(u => u.FullName).FirstOrDefault(),
                    AppointmentCount = g.Count()
                })
                .OrderByDescending(d => d.AppointmentCount)
                .ToListAsync();
        }
        public async Task<IEnumerable<AppointmentsByDoctorAndDateModel>> GetAppointmentsByDoctorAndDateAsync()
        {
            return await _ctx.Appointments
                .GroupBy(a => new { a.DoctorId, Date = a.DateTime.HasValue ? a.DateTime.Value.Date : DateTime.Now.Date }) // Перетворення DateTime? на DateTime
                .Select(g => new AppointmentsByDoctorAndDateModel
                {
                    DoctorId = g.Key.DoctorId ?? Guid.Empty,
                    DoctorName = _ctx.Users.Where(u => u.Id == g.Key.DoctorId).Select(u => u.FullName).FirstOrDefault(),
                    Date = g.Key.Date,
                    AppointmentCount = g.Count()
                })
                .OrderBy(d => d.DoctorName).ThenBy(d => d.Date)
                .ToListAsync();
        }




    }
}
