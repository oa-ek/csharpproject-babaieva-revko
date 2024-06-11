using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCenter.Core.Entities
{
    public class Diagnosis : IEntity<Guid>
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateOnly? Date {  get; set; }
        public string? diagnosis { get; set; }
        public string? Perscription { get; set; }

        public User? Doctor { get; set; }
        [ForeignKey(nameof(Doctor))]
        public Guid? DoctorId { get; set; }

        public User? Patient { get; set; }
        [ForeignKey(nameof(Patient))]
        public Guid? PatientId { get; set; }


    }
}
