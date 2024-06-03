using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCenter.Repositories.Models
{
    public class UserListItemModel
    {
        public Guid? Id { get; set; }
        public string? Email { get; set; }
        public string? FullName { get; set; }
        public string? Photo { get; set; }
        public int? Age { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public List<IdentityRole<Guid>>? Roles { get; set; }
    }
}
