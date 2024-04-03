// HomeController.cs
using Microsoft.AspNetCore.Mvc;
using StudentInformation.Models;

namespace StudentInformation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(Student student)
        {
            if (ModelState.IsValid)
            {
                // Here you would query your database or some data source
                // to retrieve student information based on the provided parameters
                // For demonstration purposes, I'm just returning a dummy message

                string message = $"Searching for student: {student.Name}, Course: {student.Course}, Semester: {student.Semester}";
                return Content(message);
            }
            else
            {
                return View("Index", student);
            }
        }
    }
}
