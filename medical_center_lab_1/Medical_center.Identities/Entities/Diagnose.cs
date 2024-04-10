using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_center.Core.Entities
{
    internal class Diagnose
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateOnly appointment_date {get; set; }
        public string diagnose { get; set; }
        public string perscription { get; set; }
    }
}
