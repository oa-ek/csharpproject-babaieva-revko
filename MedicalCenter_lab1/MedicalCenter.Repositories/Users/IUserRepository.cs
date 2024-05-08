using MedicalCenter.Core.Entities;
using MedicalCenter.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCenter.Repositories.Users
{
    public interface IUserRepository : IRepository<User, Guid>
    {
    }
}
