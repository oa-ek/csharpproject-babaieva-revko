using MedicalCenter.Repositories.Common;
using MedicalCenter.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCenter.Repositories.Appointments
{
    public interface IAppointmentRepository : IRepository<Appointment, Guid>
    {
    }
}
