using Microsoft.AspNetCore.Mvc;
using Skaitykla.MVC.Models;

namespace Skaitykla.MVC.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            //in there connect to user View
            if (!ModelState.IsValid)
            {
                ViewBag.AuthError = "blogi prisijungimo duomenys";
                return View("~/Views/Auth/Index.cshtml");
            }
            //in there connect to admin View
            if (model.Email == "test@admin" && model.Password == "Pass")
            {
                //returning View/Auth/Login.cshtml
                return RedirectToAction("Admin");
            }

            return View();
        }

        public IActionResult Admin()
        {
            return View();
        }
    }
}
