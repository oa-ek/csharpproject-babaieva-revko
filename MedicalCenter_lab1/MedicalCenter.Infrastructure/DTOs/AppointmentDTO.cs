using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCenter.Infrastructure.DTOs
{
    public class AppointmentDto
    {
        public Guid Id { get; set; }
        public DateTime? DateTime { get; set; }
        public string? Type { get; set; }
        public string? DoctorName { get; set; }
        public string? PatientName { get; set; }
    }
    public class AppointmentCreateDto
    {
        public DateTime? DateTime { get; set; }
        public string? Type { get; set; }
        public Guid? DoctorId { get; set; }
        public Guid? PatientId { get; set; }
    }

    public class AppointmentUpdateDto
    {
        public Guid Id { get; set; }
        public DateTime? DateTime { get; set; }
        public string? Type { get; set; }
        public Guid? DoctorId { get; set; }
        public Guid? PatientId { get; set; }
    }

    public class Doctor
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
    }

    public class Patient
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
    }

}
