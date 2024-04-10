using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_center.Core.Entities
{
    internal class Doctor
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
		public virtual ICollection<Appointment> applist { get; set; } = new HashSet<Appointment>();
		public string D_photo { get; set; } 
        public string Surname { get; set; } = string.Empty;
        public string Patronymic { get; set;} = string.Empty;
		public virtual ICollection<Comment> commlist { get; set; } = new HashSet<Comment>();
	}
}
