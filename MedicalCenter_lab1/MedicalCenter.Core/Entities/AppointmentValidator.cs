using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCenter.Core.Entities
{
    public class AppointmentValidator : AbstractValidator<Appointment>
    {
        public AppointmentValidator() 
        {
            RuleFor(x => x.Doctor)
                    .NotEmpty().WithMessage("Оберіть лікаря");
            RuleFor(x => x.Patient)
                .NotEmpty().WithMessage("Оберіть пацієнта");
        }
    }
}
