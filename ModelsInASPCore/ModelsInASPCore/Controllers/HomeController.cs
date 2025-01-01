using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModelsInASPCore.Models;

namespace ModelsInASPCore.Controllers
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
            var students = new List<StudentModel>
            {
                new StudentModel { rollNo = 1, Name = "Paras", Standard = 11, Gender = "Male"},
                new StudentModel { rollNo = 2, Name = "Ranjana", Standard = 11, Gender = "Female"},
                new StudentModel { rollNo = 3, Name = "Vijay", Standard = 10, Gender = "Male"}
            };
            ViewData["myStudents"] = students;
            return View();
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
