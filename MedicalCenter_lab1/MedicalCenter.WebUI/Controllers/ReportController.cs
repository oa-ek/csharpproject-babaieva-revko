using MedicalCenter.Repositories.Users;
using MedicalCenter.Repositories.Appointments;

using Microsoft.AspNetCore.Mvc;

namespace MedicalCenter.WebUI.Controllers
{
    public class ReportsController : Controller
    {
        private readonly IUserRepository _userRepository;

        public ReportsController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult DoctorPopularityReport()
        {
            return View();
        }

        // API метод для отримання даних про популярність лікарів
        [HttpGet]
        public async Task<IActionResult> GetDoctorPopularity()
        {
            var data = await _userRepository.GetDoctorPopularityAsync();
            return Json(data);
        }

        // API метод для отримання даних про кількість записів на прийом за датами
        [HttpGet]
        public async Task<IActionResult> GetAppointmentsByDoctorAndDate()
        {
            var data = await _userRepository.GetAppointmentsByDoctorAndDateAsync();
            return Json(data);
        }
    }
}
