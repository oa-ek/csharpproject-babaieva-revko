using MedicalCenter.Core.Context;
using MedicalCenter.Core.Entities;
using MedicalCenter.Repositories.Appointments;
using MedicalCenter.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCenter.Repositories.Users
{
    public class UserRepository : Repository<User, Guid>, IUserRepository
    {
        public UserRepository(ProjectContext ctx) : base(ctx) { }
    }
}
