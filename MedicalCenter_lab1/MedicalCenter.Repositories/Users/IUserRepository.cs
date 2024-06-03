using MedicalCenter.Core.Entities;
using MedicalCenter.Repositories.Common;
using MedicalCenter.Repositories.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCenter.Repositories.Users
{
    public interface IUserRepository : IRepository<User, Guid>
    {
        Task<IEnumerable<UserListItemModel>> GetAllWithRolesAsync();
        //Task<User> CreateWithPasswordAsync(UserCreateModel model);
       Task<IEnumerable<IdentityRole<Guid>>> GetRolesAsync();
        Task<UserListItemModel> GetOneWithRolesAsync(Guid id);
        //Task UpdateUserAsync(UserListItemModel model, string[] roles);

        Task<bool> CheckUser(Guid id);
        Task DeleteUser(Guid id);
    }
}
