using Humanizer;
using MedicalCenter.Core.Entities;
using MedicalCenter.Repositories.Appointments;
using MedicalCenter.Repositories.Comments;
using MedicalCenter.Repositories.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;

namespace MedicalCenter.WebUI.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IUserRepository _userRepository;

        private readonly IWebHostEnvironment _webHostEnvironment;

        public CommentController(
           ICommentRepository commentRepository,
            IUserRepository userRepository,
            IWebHostEnvironment webHostEnvironment)
        {
            _commentRepository = commentRepository;
            _userRepository = userRepository;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _commentRepository.GetAllAsync());
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Doctors = (await _userRepository.GetAllAsync())
                .Select(x => new SelectListItem { Text = x.FullName, Value = x.Id.ToString() }).ToList();

            return View(new Comment());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Comment model)
        {
            if (ModelState.IsValid)
            {
                await _commentRepository.CreateAsync(model);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Doctors = (await _userRepository.GetAllAsync())
                .Select(x => new SelectListItem { Text = x.FullName, Value = x.Id.ToString() }).ToList();

            return View(model);
        }
        [HttpGet("Comment/Edit/{id}")]
        public async Task<IActionResult> Edit(Guid id)
        {
            var comment = await _commentRepository.GetAsync(id);
            if (comment == null)
            {
                return NotFound();
            }

            ViewBag.Doctors = (await _userRepository.GetAllAsync())
                .Select(x => new SelectListItem { Text = x.FullName, Value = x.Id.ToString() }).ToList();

            return View(comment);
        }

        [HttpPost("Comment/Edit/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Comment model)
        {
            if (ModelState.IsValid)
            {
                await _commentRepository.UpdateAsync(model);
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Doctors = (await _userRepository.GetAllAsync())
                .Select(x => new SelectListItem { Text = x.FullName, Value = x.Id.ToString() }).ToList();

            return View(model);
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            return View(await _commentRepository.GetAsync(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Guid id, IFormCollection form)
        {
            try
            {
                await _commentRepository.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction("Delete", new { id = id });
            }
        }
    }
}
