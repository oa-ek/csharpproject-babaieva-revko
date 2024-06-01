using Humanizer;
using MedicalCenter.Core.Entities;
using MedicalCenter.Repositories.Appointments;
using MedicalCenter.Repositories.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;

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
            return View( await _appointmentRepository.GetAllAsync());
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Doctors = (await _userRepository.GetAllAsync())
                .Select(x => new SelectListItem { Text = x.FullName, Value = x.Id.ToString() }).ToList();

            return View(new Appointment());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Appointment model)
        {
            if (ModelState.IsValid)
            {
                await _appointmentRepository.CreateAsync(model);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Doctors = (await _userRepository.GetAllAsync())
                .Select(x => new SelectListItem { Text = x.FullName, Value = x.Id.ToString()}).ToList();

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

            ViewBag.Doctors = (await _userRepository.GetAllAsync())
                .Select(x => new SelectListItem { Text = x.FullName, Value = x.Id.ToString() }).ToList();

            return View(appointment);
        }

        [HttpPost("Appointment/Edit/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Appointment model)
        {
            if (ModelState.IsValid)
            {
                await _appointmentRepository.UpdateAsync(model);
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Doctors = (await _userRepository.GetAllAsync())
                .Select(x => new SelectListItem { Text = x.FullName, Value = x.Id.ToString() }).ToList();

            return View(model);
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            return View(await _appointmentRepository.GetAsync(id));
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
    }
}
