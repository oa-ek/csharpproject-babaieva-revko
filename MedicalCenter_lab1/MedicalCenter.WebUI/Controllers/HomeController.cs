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

        private readonly IRepository<Appointment, Guid> repository;
        public HomeController(ILogger<HomeController> logger,
            IRepository<Appointment, Guid> repository)
        {
            _logger = logger;
            this.repository = repository;
        }
        public IActionResult Index()
        {
            return View(repository.GetAllAsync());
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
