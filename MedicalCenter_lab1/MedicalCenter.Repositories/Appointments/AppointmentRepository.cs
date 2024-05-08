using MedicalCenter.Core.Context;
using MedicalCenter.Core.Entities;
using MedicalCenter.Repositories.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCenter.Repositories.Appointments
{
    public class AppointmentRepository : Repository<Appointment, Guid>, IAppointmentRepository
    {
        public AppointmentRepository(ProjectContext ctx) : base(ctx) { }

        public async override Task<IEnumerable<Appointment>> GetAllAsync()
        {
            return await _ctx.Appointments
                .Include(x => x.Patient)
                .Include(x => x.Doctor)
                .ToListAsync();
        }

    }
}
