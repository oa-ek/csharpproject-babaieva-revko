using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCenter.Core.Entities
{
    public class Appointment : IEntity<Guid>
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime? DateTime { get; set; }
        public string? Type { get; set; }

        public User? Doctor { get; set; }

        [ForeignKey(nameof(Doctor))]
        public string DoctorId { get; set; }

        public User? Patient { get; set; }
        [ForeignKey(nameof(Patient))]
        public string PatientId { get; set; }


    }
}
