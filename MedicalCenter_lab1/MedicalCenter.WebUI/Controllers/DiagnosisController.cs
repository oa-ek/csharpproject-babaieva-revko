using Humanizer;
using MedicalCenter.Core.Entities;
using MedicalCenter.Repositories.Diagnoses;
using MedicalCenter.Repositories.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MedicalCenter.WebUI.Controllers
{
    public class DiagnosisController : Controller
    {
        private readonly IDiagnosisRepository _diagnosisRepository;
        private readonly IUserRepository _userRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public DiagnosisController(
           IDiagnosisRepository diagnosisRepository,
            IUserRepository userRepository,
            IWebHostEnvironment webHostEnvironment)
        {
            _diagnosisRepository = diagnosisRepository;
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


            var diagnoses = await _diagnosisRepository.GetAllAsync();
            var userDiagnoses = diagnoses.Where(a => a.PatientId.ToString() == userId).ToList();
            var sortedDiagnoses = userDiagnoses.OrderByDescending(d => d.Date).ToList();
            return View(sortedDiagnoses);
        }

        public async Task<IActionResult> Create()
        {
            var doctors = await _userRepository.GetUsersByRoleAsync("Doctor");
            ViewBag.Doctors = doctors
                .Select(x => new SelectListItem { Text = x.FullName, Value = x.Id.ToString() }).ToList();
            return View(new Diagnosis());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Diagnosis model)
        {
            if (ModelState.IsValid)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (string.IsNullOrEmpty(userId))
                {
                    return Unauthorized();
                }
                model.PatientId = Guid.Parse(userId);

                await _diagnosisRepository.CreateAsync(model);
                return RedirectToAction(nameof(Index));
            }

            var doctors = await _userRepository.GetUsersByRoleAsync("Doctor");
            ViewBag.Doctors = doctors
                .Select(x => new SelectListItem { Text = x.FullName, Value = x.Id.ToString() }).ToList();

            return View(model);
        }

        [HttpGet("Diagnosis/Edit/{id}")]
        public async Task<IActionResult> Edit(Guid id)
        {

            

            var diagnosis = await _diagnosisRepository.GetAsync(id);
            if (diagnosis == null)
            {
                return NotFound();
            }
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (diagnosis.PatientId.ToString() != userId)
            {
                return Unauthorized();
            }
            var doctors = await _userRepository.GetUsersByRoleAsync("Doctor");
            ViewBag.Doctors = doctors
                .Select(x => new SelectListItem { Text = x.FullName, Value = x.Id.ToString() }).ToList();

            return View(diagnosis);
        }

        [HttpPost("Diagnosis/Edit/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Diagnosis model)
        {

            

            if (ModelState.IsValid)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                model.PatientId = new Guid(userId);
                await _diagnosisRepository.UpdateAsync(model);
                return RedirectToAction(nameof(Index));
            }
            var doctors = await _userRepository.GetUsersByRoleAsync("Doctor");
            ViewBag.Doctors = doctors
                .Select(x => new SelectListItem { Text = x.FullName, Value = x.Id.ToString() }).ToList();

            return View(model);
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            return View(await _diagnosisRepository.GetAsync(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Guid id, IFormCollection form)
        {
            try
            {
                await _diagnosisRepository.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction("Delete", new { id = id });
            }
        }
    }
}
