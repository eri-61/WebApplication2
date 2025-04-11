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

        public IActionResult Course()
        {
            CourseViewModel resp = new CourseViewModel();
            using (var db = new StudInfoSys1Context())
            {
                resp.Courses = db.Courses.ToList();
            }
            return View(resp);
        }
        public IActionResult Section()
        {
            SectionViewModel resp = new SectionViewModel();
            using (var db = new StudInfoSys1Context())
            {
                resp.Sections = db.Sections.ToList();
            }
            return View(resp);
        }
        public IActionResult Room()
        {
            RoomViewModel resp = new RoomViewModel();
            using (var db = new StudInfoSys1Context())
            {
                resp.Rooms = db.Rooms.ToList();
            }
            return View(resp);
        }
        public IActionResult Teacher()
        {
            TeacherViewModel resp = new TeacherViewModel();
            using (var db = new StudInfoSys1Context())
            {
                resp.Teachers = db.Teachers.ToList();
            }
            return View(resp);
        }

    }
}
