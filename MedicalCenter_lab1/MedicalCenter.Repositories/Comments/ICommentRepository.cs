using MedicalCenter.Core.Entities;
using MedicalCenter.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCenter.Repositories.Comments
{
    public interface ICommentRepository : IRepository<Comment, Guid>
    {
    }
}
