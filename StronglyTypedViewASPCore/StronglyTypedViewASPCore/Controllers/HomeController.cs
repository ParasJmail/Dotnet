using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StronglyTypedViewASPCore.Models;

namespace StronglyTypedViewASPCore.Controllers
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
            //Employee obj = new Employee()
            //{
            //    EmpId = 101,
            //    EmpName = "Paras",
            //    Designation = "Engineer",
            //    Salary = 2500
            //};

            var myEmployees = new List<Employee>
            {
                new Employee {EmpId = 1,EmpName = "Paras",Designation = "Engineer"},
                new Employee {EmpId = 1,EmpName = "Paras",Designation = "Engineer"},
                new Employee {EmpId = 1,EmpName = "Paras",Designation = "Engineer"},
                new Employee {EmpId = 1,EmpName = "Paras",Designation = "Engineer"}
            };
            return View(myEmployees);
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
