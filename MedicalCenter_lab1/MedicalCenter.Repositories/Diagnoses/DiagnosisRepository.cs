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

namespace MedicalCenter.Repositories.Diagnoses
{
    public class DiagnosisRepository : Repository<Diagnosis, Guid>, IDiagnosisRepository
    {
        public DiagnosisRepository(ProjectContext ctx) : base(ctx) { }

        public async override Task<IEnumerable<Diagnosis>> GetAllAsync()
        {
            return await _ctx.Diagnosis
                .Include(x => x.Patient)
                .ToListAsync();
        }
    }
}
