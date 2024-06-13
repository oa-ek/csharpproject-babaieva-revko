using ClosedXML.Excel;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using Humanizer;
using MedicalCenter.Core.Entities;
using MedicalCenter.Repositories.Diagnoses;
using MedicalCenter.Repositories.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using ClosedXML.Excel;

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

        public async Task<IActionResult> GenerateReport()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized();
            }

            var diagnoses = await _diagnosisRepository.GetAllAsync();
            var userDiagnoses = diagnoses
                .Where(d => d.PatientId.ToString() == userId)
                .ToList();
            /*var userDiagnoses = diagnoses
                .Where(d => d.PatientId.ToString() == userId && d.Date.HasValue && d.Date.Value >= DateOnly.FromDateTime(DateTime.Now.AddMonths(-1)))
                .ToList();
            */
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Report");

                // Headers
                worksheet.Cells[1, 1].Value = "Дата запису";
                worksheet.Cells[1, 2].Value = "Діагноз";
                worksheet.Cells[1, 3].Value = "Призначення";
                worksheet.Cells[1, 4].Value = "Ім'я лікаря";

                // Data
                for (int i = 0; i < userDiagnoses.Count; i++)
                {
                    var diagnosis = userDiagnoses[i];
                    worksheet.Cells[i + 2, 1].Value = diagnosis.Date?.ToString("dd-MM-yyyy");
                    worksheet.Cells[i + 2, 2].Value = diagnosis.diagnosis;
                    worksheet.Cells[i + 2, 3].Value = diagnosis.Perscription;
                    worksheet.Cells[i + 2, 4].Value = diagnosis.Doctor?.FullName;
                }

                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                var stream = new MemoryStream();
                package.SaveAs(stream);
                stream.Position = 0;

                var fileName = $"Report_{DateTime.Now:yyyyMMddHHmmss}.xlsx";
                return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
            }
        }
    }
}
