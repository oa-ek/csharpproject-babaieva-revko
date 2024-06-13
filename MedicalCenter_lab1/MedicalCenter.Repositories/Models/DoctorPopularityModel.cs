using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCenter.Repositories.Models
{
    public class DoctorPopularityModel
    {
        public Guid DoctorId { get; set; }
        public string DoctorName { get; set; }
        public int AppointmentCount { get; set; }
    }
}
