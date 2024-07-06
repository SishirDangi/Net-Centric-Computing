using Microsoft.AspNetCore.Mvc;
using StudentInfoApp.ViewModels;

namespace StudentInfoApp.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new StudentViewModel());
        }

        [HttpPost]
        public IActionResult Index(StudentViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.IsValid = true;
                return View(model);
            }

            model.IsValid = false;
            return View(model);
        }
    }
}
