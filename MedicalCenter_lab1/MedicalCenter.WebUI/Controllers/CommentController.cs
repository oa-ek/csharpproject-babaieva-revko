using Humanizer;
using MedicalCenter.Core.Entities;
using MedicalCenter.Repositories.Comments;
using MedicalCenter.Repositories.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

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
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized();
            }

            var comments = await _commentRepository.GetAllAsync();
            List<Comment> filteredComments;

            if (User.IsInRole("Doctor"))
            {
                filteredComments = comments.Where(c => c.DoctorId.ToString() == userId).ToList();
            }
            else if (User.IsInRole("Patient"))
            {
                filteredComments = comments.Where(c => c.PatientId.ToString() == userId).ToList();
            }
            else
            {
                return Unauthorized();
            }

            return View(filteredComments);
        }

        public async Task<IActionResult> Create()
        {
            var doctors = await _userRepository.GetUsersByRoleAsync("Doctor");
            ViewBag.Doctors = doctors
                .Select(x => new SelectListItem { Text = x.FullName, Value = x.Id.ToString() }).ToList();

            return View(new Comment());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Comment model)
        {
            if (ModelState.IsValid)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (string.IsNullOrEmpty(userId))
                {
                    return Unauthorized();
                }
                model.PatientId = Guid.Parse(userId);
                model.CreatedOn = DateTime.UtcNow;
                await _commentRepository.CreateAsync(model);
                return RedirectToAction(nameof(Index));
            }

            var doctors = await _userRepository.GetUsersByRoleAsync("Doctor");
            ViewBag.Doctors = doctors
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

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (comment.PatientId.ToString() != userId)
            {
                return Unauthorized();
            }

            var doctors = await _userRepository.GetUsersByRoleAsync("Doctor");
            ViewBag.Doctors = doctors
                .Select(x => new SelectListItem { Text = x.FullName, Value = x.Id.ToString() }).ToList();

            return View(comment);
        }

        [HttpPost("Comment/Edit/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, Comment model)
        {
            if (ModelState.IsValid)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var existingComment = await _commentRepository.GetAsync(id);

                if (existingComment == null)
                {
                    return NotFound();
                }

                if (existingComment.PatientId.ToString() != userId)
                {
                    return Unauthorized();
                }

                // Update the existing comment with values from the model
                existingComment.DoctorId = model.DoctorId;
                existingComment.Title = model.Title;
                existingComment.MainText = model.MainText;
                // Ensure CreatedOn is not modified
                existingComment.CreatedOn = existingComment.CreatedOn;

                await _commentRepository.UpdateAsync(existingComment);
                return RedirectToAction(nameof(Index));
            }

            var doctors = await _userRepository.GetUsersByRoleAsync("Doctor");
            ViewBag.Doctors = doctors
                .Select(x => new SelectListItem { Text = x.FullName, Value = x.Id.ToString() }).ToList();

            return View(model);
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var comment = await _commentRepository.GetAsync(id);
            if (comment == null)
            {
                return NotFound();
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (comment.PatientId.ToString() != userId)
            {
                return Unauthorized();
            }

            return View(comment);
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
