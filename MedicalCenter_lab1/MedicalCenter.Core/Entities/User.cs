using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCenter.Core.Entities
{
    public class User : IdentityUser, IEntity<string>
    {
        public string? FullName { get; set; }
        public string? Photo { get; set; }
        public int? Age { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public string? Address { get; set; }
        public virtual ICollection<Appointment> DoctorAppointments { get; set; } = new HashSet<Appointment>();
        public virtual ICollection<Appointment> PatientAppointments { get; set; } = new HashSet<Appointment>();
        public virtual ICollection<Diagnosis> MedRecord { get; set; } = new HashSet<Diagnosis>();
        public virtual ICollection<Comment> DoctorComments { get; set; } = new HashSet<Comment>();
        public virtual ICollection<Comment> PatientComments { get; set; } = new HashSet<Comment>();




    }
}
