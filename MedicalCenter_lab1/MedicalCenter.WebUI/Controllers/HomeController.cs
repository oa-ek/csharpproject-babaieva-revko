using MedicalCenter.Core.Entities;
using MedicalCenter.Repositories.Common;
using MedicalCenter.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System.Diagnostics;

namespace MedicalCenter.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IRepository<Appointment, Guid> app_repository;
        private readonly IRepository<Diagnosis, Guid> dia_repository;

        public HomeController(ILogger<HomeController> logger,
            IRepository<Appointment, Guid> app_repository, IRepository<Diagnosis, Guid> dia_repository)
        {
            _logger = logger;
            this.app_repository = app_repository;
            this.dia_repository = dia_repository;
        }
        public IActionResult Index()
        {
            var appointments = app_repository.GetAllAsync();
            var diagnoses = dia_repository.GetAllAsync();
            return View((appointments, diagnoses));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
