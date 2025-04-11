using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            return View();
        }

       
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Course()
        {
            return View();
        }
        public IActionResult Section()
        {
            return View();
        }
        public IActionResult Room()
        {
            return View();
        }
        public IActionResult Teacher()
        {
            return View();
        }
    }
}
