using FirstResponsiveWebAppBurgett.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstResponsiveWebAppBurgett.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.AgeToday = "";
            ViewBag.Name = "";
            return View();
        }

        [HttpPost]
        public IActionResult Index(FirstResponsiveModel fr)
        {
            if (ModelState.IsValid)
            {
                ViewBag.AgeToday = fr.AgeThisYear().ToString();
                ViewBag.Name = fr.name;
            }
            else
            {
                ViewBag.AgeToday = "";
            }

            return View();
        }
    }
}
