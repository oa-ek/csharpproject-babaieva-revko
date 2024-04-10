using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_center.Core.Entities
{
	internal class Appointment_type
	{
		public string Title {  get; set; }
		public Guid appTypeId { get; set; }
	}
}
