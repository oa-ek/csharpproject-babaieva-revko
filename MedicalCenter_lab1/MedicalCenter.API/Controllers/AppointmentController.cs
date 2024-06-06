using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using MedicalCenter.Core.Entities;
using MedicalCenter.Infrastructure.DTOs;
using MedicalCenter.Repositories.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedicalCenter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IRepository<Appointment, Guid> _appointmentRepository;
        private readonly IMapper _mapper;
        public AppointmentController(IRepository<Appointment, Guid> appointmentRepository, IMapper mapper)
        {
            _appointmentRepository = appointmentRepository;
            _mapper = mapper;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll()
        {
            var appointments = await _appointmentRepository.GetAllAsync();
            return Ok(appointments);
        }
        [HttpPost("add")]
        public async Task<ActionResult<Appointment>> AddAppointment(AppointmentCreateDto appointment)
        {
            if (appointment == null)
            {
                return BadRequest("Appointment wasn't found");
            }
            await _appointmentRepository.CreateAsync(_mapper.Map<Appointment>(appointment));
            return Ok(appointment);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Appointment>> GetGenreById(Guid id)
        {
            var appointment = await _appointmentRepository.GetAsync(id);
            if (appointment is null)
                return NotFound("Appointment not found");
            return Ok(appointment);
        }
        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> DeleteGenre(Guid id)
        {
            var appointment = await _appointmentRepository.GetAsync(id);
            if (appointment is null)
                return NotFound("Appointment not found");
            await _appointmentRepository.DeleteAsync(id);
            return Ok($"Appointment {appointment.DateTime} deleted");
        }
        [HttpPut("update")]
        public async Task<ActionResult<Appointment>> UpdateAppointment(AppointmentUpdateDto appointmentDTO)
        {
            var appointment = _mapper.Map<Appointment>(appointmentDTO);
            if (appointment.Id == null)
            {
                return BadRequest("Appointment not found");
            }

            // Retrieve the existing genre from the database
            var existingAppointment = await _appointmentRepository.GetAsync(appointment.Id);
            if (existingAppointment == null)
            {
                return NotFound("Appointment not found");
            }

            // Update the title genreDTO
            existingAppointment.DateTime = appointmentDTO.DateTime;
            existingAppointment.Type = appointmentDTO.Type;
            existingAppointment.DoctorId = appointmentDTO.DoctorId;
            existingAppointment.PatientId = appointmentDTO.PatientId;

            // Save the updated role to the database
            await _appointmentRepository.UpdateAsync(existingAppointment);

            return Ok(existingAppointment);
        }
    }
}
