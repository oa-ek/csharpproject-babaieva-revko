using Humanizer;
using MedicalCenter.Repositories.Appointments;
using MedicalCenter.Repositories.Users;
using Microsoft.AspNetCore.Mvc;

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


    }
}
