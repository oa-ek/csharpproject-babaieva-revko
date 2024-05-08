using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCenter.Core.Entities
{
    public class User : IdentityUser<Guid>, IEntity<Guid>
    {
        public string? FullName { get; set; } = string.Empty;
        public string? Photo { get; set; } = "/no-avatar.jpg";
        public int? Age { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public string? Address { get; set; }
        public virtual ICollection<Appointment> DoctorAppointments { get; set; } = new HashSet<Appointment>();
        public virtual ICollection<Appointment> PatientAppointments { get; set; } = new HashSet<Appointment>();
        public virtual ICollection<Diagnosis> MedRecord { get; set; } = new HashSet<Diagnosis>();
        public virtual ICollection<Comment> DoctorComments { get; set; } = new HashSet<Comment>();
        public virtual ICollection<Comment> PatientComments { get; set; } = new HashSet<Comment>();

        [NotMapped]
        public IFormFile? ImageFile { get; set; }




    }
}
