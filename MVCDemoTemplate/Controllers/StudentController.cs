using Microsoft.AspNetCore.Mvc;
using MVCDemoTemplate.Models;

namespace MVCDemoTemplate.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Student student = new Student
            {
                Id = 100,
                Name = "Dinesh",
                Faculty = "Computer Science and Information Technology",
                Batch = "2083"
            };
            return View(student);
        }
    }
}
