using AutoMapper;
using MedicalCenter.Core.Entities;
using MedicalCenter.Infrastructure.DTOs;

namespace MedicalCenter.API.Helpers
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<Appointment, AppointmentDto>().ReverseMap();
            CreateMap<Appointment, AppointmentCreateDto>().ReverseMap();
            CreateMap<Appointment, AppointmentUpdateDto>().ReverseMap();
            CreateMap<AppointmentDto, AppointmentUpdateDto>().ReverseMap();
/*
            CreateMap<AppointmentCreateDTO, Appointment>()
            .ForMember(dest => dest.Doctor, opt => opt.Ignore())
            .ForMember(dest => dest.Patient, opt => opt.Ignore());

            CreateMap<AppointmentUpdateDTO, Appointment>()
                .ForMember(dest => dest.Doctor, opt => opt.Ignore())
                .ForMember(dest => dest.Patient, opt => opt.Ignore());
*/
            /*CreateMap<Appointment, AppointmentDTO>()
                .ForMember(dest => dest.DoctorName, opt => opt.MapFrom(src => src.Doctor.Name))
                .ForMember(dest => dest.PatientName, opt => opt.MapFrom(src => src.Patient.Name));
            */
            // Mapping between Doctor DTOs and Entity
            CreateMap<Doctor, User>();
            CreateMap<User, Doctor>();

            // Mapping between Patient DTOs and Entity
            CreateMap<Patient, User>();
            CreateMap<User, Patient>();
        }
    }
}
