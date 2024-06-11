using Humanizer;
using MedicalCenter.Core.Entities;
using MedicalCenter.Repositories.Appointments;
using MedicalCenter.Repositories.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MedicalCenter.WebUI.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IUserRepository _userRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AppointmentController(
           IAppointmentRepository appointmentRepository,
            IUserRepository userRepository,
            IWebHostEnvironment webHostEnvironment)
        {
            _appointmentRepository = appointmentRepository;
            _userRepository = userRepository;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized();
            }

            var appointments = await _appointmentRepository.GetAllAsync();
            List<Appointment> filteredAppointments;

            if (User.IsInRole("Admin"))
            {
                filteredAppointments = appointments.ToList();
            }
            else if (User.IsInRole("Doctor"))
            {
                filteredAppointments = appointments.Where(a => a.DoctorId.ToString() == userId).ToList();
            }
            else if (User.IsInRole("Patient"))
            {
                filteredAppointments = appointments.Where(a => a.PatientId.ToString() == userId).ToList();
            }
            else
            {
                return Unauthorized();
            }

            return View(filteredAppointments);
        }

        public async Task<IActionResult> Create()
        {
            await PopulateDoctorAndPatientLists();
            return View(new Appointment());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Appointment model)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (ModelState.IsValid)
            {
                if (User.IsInRole("Patient"))
                {
                    model.PatientId = Guid.Parse(userId);
                }
                else if (User.IsInRole("Doctor"))
                {
                    model.DoctorId = Guid.Parse(userId);
                }

                if (model.PatientId == model.DoctorId)
                {
                    ModelState.AddModelError("", "Doctor and Patient cannot be the same person.");
                    await PopulateDoctorAndPatientLists();
                    return View(model);
                }

                await _appointmentRepository.CreateAsync(model);
                return RedirectToAction(nameof(Index));
            }

            await PopulateDoctorAndPatientLists();
            return View(model);
        }

        [HttpGet("Appointment/Edit/{id}")]
        public async Task<IActionResult> Edit(Guid id)
        {
            var appointment = await _appointmentRepository.GetAsync(id);
            if (appointment == null)
            {
                return NotFound();
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (appointment.PatientId.ToString() != userId && appointment.DoctorId.ToString() != userId && !User.IsInRole("Admin"))
            {
                return Unauthorized();
            }

            await PopulateDoctorAndPatientLists(); // Populate doctor and patient lists
            return View(appointment);
        }

        [HttpPost("Appointment/Edit/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Appointment model)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (ModelState.IsValid)
            {
                var appointment = await _appointmentRepository.GetAsync(id);

                if (appointment == null)
                {
                    return NotFound();
                }

                if (appointment.PatientId.ToString() != userId && appointment.DoctorId.ToString() != userId && !User.IsInRole("Admin"))
                {
                    return Unauthorized();
                }

                appointment.DateTime = model.DateTime;
                appointment.DoctorId = model.DoctorId;
                appointment.Type = model.Type;

                if (User.IsInRole("Doctor"))
                {
                    appointment.PatientId = model.PatientId; // Assign selected patient if user is a doctor
                }

                if (appointment.PatientId == appointment.DoctorId)
                {
                    ModelState.AddModelError("", "Doctor and Patient cannot be the same person.");
                    await PopulateDoctorAndPatientLists();
                    return View(model);
                }

                await _appointmentRepository.UpdateAsync(appointment);
                return RedirectToAction(nameof(Index));
            }

            await PopulateDoctorAndPatientLists();
            return View(model);
        }



        public async Task<IActionResult> Delete(Guid id)
        {
            var appointment = await _appointmentRepository.GetAsync(id);
            if (appointment == null)
            {
                return NotFound();
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (appointment.PatientId.ToString() != userId && appointment.DoctorId.ToString() != userId && !User.IsInRole("Admin"))
            {
                return Unauthorized();
            }

            return View(appointment);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Guid id, IFormCollection form)
        {
            try
            {
                await _appointmentRepository.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction("Delete", new { id = id });
            }
        }

        private async Task PopulateDoctorAndPatientLists()
        {
            if (User.IsInRole("Admin") || User.IsInRole("Patient"))
            {
                var doctors = await _userRepository.GetUsersByRoleAsync("Doctor");
                ViewBag.Doctors = doctors
                    .Select(x => new SelectListItem { Text = x.FullName, Value = x.Id.ToString() }).ToList();
            }

            if (User.IsInRole("Admin") || User.IsInRole("Doctor"))
            {
                var patients = await _userRepository.GetUsersByRoleAsync("Patient");
                ViewBag.Patients = patients
                    .Select(x => new SelectListItem { Text = x.FullName, Value = x.Id.ToString() }).ToList();
            }
        }
    }
}
