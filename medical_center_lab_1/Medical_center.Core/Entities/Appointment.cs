using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_center.Core.Entities
{
	internal class Appointment
	{
		public DateTime DateTime { get; set; }
		public Guid Id  { get; set; } = Guid.NewGuid();
		[ForeignKey(nameof(Doctor))]
		public Guid doctorId { get; set; }
		[ForeignKey(nameof(Appointment_type))]
		public Guid appTypeId { get; set; }
		[ForeignKey(nameof(Patient))]
		public Guid patientId { get; set; }
	}
}
