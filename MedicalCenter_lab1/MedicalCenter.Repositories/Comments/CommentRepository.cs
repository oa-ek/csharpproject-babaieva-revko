using MedicalCenter.Core.Context;
using MedicalCenter.Core.Entities;
using MedicalCenter.Repositories.Common;
using MedicalCenter.Repositories.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCenter.Repositories.Comments
{
    public class CommentRepository : Repository<Comment, Guid>, ICommentRepository
    {
        public CommentRepository(ProjectContext ctx) : base(ctx) { }
        public async override Task<IEnumerable<Comment>> GetAllAsync()
        {
            return await _ctx.Comments
                .Include(x => x.Patient)
                .Include(x => x.Doctor)
                .ToListAsync();
        }
    }
}
