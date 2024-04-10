using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_center.Core.Entities
{
    internal class Patient
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Name { get; set; } = string.Empty;
        public string? Surname { get; set; } = string.Empty;
        public string? Patronimic { get; set; } = string.Empty;
        public bool gender { get; set; }
        public int? age { get; set; }
        public string? p_photo { get; set; }
        public string? adress { get; set; }
        public DateOnly? date_of_birth { get; set; }
        public string? phone_number {  get; set; }
        public string? email { get; set; }
        public virtual ICollection<Diagnose> med_record { get; set; } = new HashSet<Diagnose>();
        public virtual ICollection<Appointment> appointments { get; set; } = new HashSet<Appointment> ();
        public virtual ICollection<Comment> comments { get; set; } = new HashSet<Comment>();
    }
}
