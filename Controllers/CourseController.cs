using btk.Models;
using Microsoft.AspNetCore.Mvc;

namespace btk.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply(Candidate model)
        {
            return View();
        }
    }
}