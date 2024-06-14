using MedicalCenter.Repositories.Models;
using MedicalCenter.Repositories.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace MedicalCenter.WebUI.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository userRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public UserController(IUserRepository userRepository, IWebHostEnvironment webHostEnvironment)
        {
            this.userRepository = userRepository;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            string pageTitle = User.IsInRole("Doctor") ? "Пацієнти" : User.IsInRole("Patient") ? "Лікарі" : "Користувачі";
            ViewData["Title"] = pageTitle;

            return View(await userRepository.GetAllWithRolesAsync());
        }

        // GET: User/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateUserModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile != null)
                {
                    var fileName = Path.GetFileNameWithoutExtension(model.ImageFile.FileName);
                    var extension = Path.GetExtension(model.ImageFile.FileName);
                    var newFileName = $"{fileName}_{DateTime.Now:yyyyMMddHHmmss}{extension}";
                    var path = Path.Combine(_webHostEnvironment.WebRootPath, "images", newFileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await model.ImageFile.CopyToAsync(stream);
                    }

                    model.Photo = $"/images/{newFileName}";
                }

                var user = await userRepository.CreateWithPasswordAsync(model);
                if (user != null)
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Failed to create user.");
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            ViewBag.Roles = await userRepository.GetRolesAsync();
            return View(await userRepository.GetOneWithRolesAsync(id));
        }

        /*[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UserListItemModel model, string[] roles)
        {
            if (ModelState.IsValid)
            {
                await userRepository.UpdateUserAsync(model, roles);
                return RedirectToAction("Index");
            }
            ViewBag.Roles = await userRepository.GetRolesAsync();
            return View(model);
        }*/

        [HttpPost]
        public async Task<int> CheckDelete(Guid id)
        {
            var check = await userRepository.CheckUser(id);
            return check ? 1 : 0;
        }

        [HttpDelete]
        public async Task Delete(Guid id)
        {
            await userRepository.DeleteUser(id);
        }


    }
}
