using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCenter.Core.Entities
{
    public class Comment : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? MainText { get; set; }
        public DateTime? CreatedOn { get; set; }

        public User? Doctor { get; set; }
        [ForeignKey(nameof(Doctor))]
        public Guid? DoctorId { get; set; }

        public User? Patient { get; set; }
        [ForeignKey(nameof(Patient))]
        public Guid? PatientId { get; set; }


    }
}
