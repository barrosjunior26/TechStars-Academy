using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TechStars_Academy.Models;

namespace TechStars_Academy.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
