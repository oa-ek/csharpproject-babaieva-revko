using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_center.Core.Entities
{
	internal class Comment
	{
		[ForeignKey(nameof(Comment))]
		public Guid commentId { get; set; }
		public string Title { get; set; } = string.Empty;
		public string MainText { get; set; } = string.Empty;
		[ForeignKey(nameof(Doctor))]
		public Guid doctorId { get; set; }
		[ForeignKey(nameof(Patient))]
		public Guid patientId { get; set; }

	}
}
