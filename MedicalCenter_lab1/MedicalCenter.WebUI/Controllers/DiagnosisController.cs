using Humanizer;
using MedicalCenter.Core.Entities;
using MedicalCenter.Repositories.Diagnoses;
using MedicalCenter.Repositories.Users;
using Microsoft.AspNetCore.Mvc;
using System;
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
            var diagnoses = await _diagnosisRepository.GetAllAsync();
            var sortedDiagnoses = diagnoses.OrderByDescending(d => d.Date).ToList();
            return View(sortedDiagnoses);
        }

        public IActionResult Create()
        {
            return View(new Diagnosis());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Diagnosis model)
        {
            if (ModelState.IsValid)
            {
                await _diagnosisRepository.CreateAsync(model);
                return RedirectToAction(nameof(Index));
            }
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
            return View(diagnosis);
        }

        [HttpPost("Diagnosis/Edit/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Diagnosis model)
        {
            if (ModelState.IsValid)
            {
                await _diagnosisRepository.UpdateAsync(model);
                return RedirectToAction(nameof(Index));
            }
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
