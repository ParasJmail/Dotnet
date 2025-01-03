using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModelData.Models;

namespace ModelData.Controllers
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
            //Employee emp = new Employee()
            //{
            //    EmpId = 101,
            //    EmpName = "Paras",
            //    Designation = "Trainee",
            //    Salary = 45000
            //};

            var myEmployees = new List<Employee>()
            {
                new Employee {EmpId = 1, EmpName = "Paras", Designation = "Trainee" , Salary = 45000},
                new Employee {EmpId = 1, EmpName = "Paras", Designation = "Trainee" , Salary = 45000},
                new Employee {EmpId = 1, EmpName = "Paras", Designation = "Trainee" , Salary = 45000},
                new Employee {EmpId = 1, EmpName = "Paras", Designation = "Trainee" , Salary = 45000},
                new Employee {EmpId = 1, EmpName = "Paras", Designation = "Trainee" , Salary = 45000}
            };

            //ViewData["myEmployee"] = myEmployees;
            ViewBag.Employees = myEmployees;
            //ViewData["myEmployee"] = emp;
            //ViewBag.myEmployee = emp;
            //TempData["myEmployee"] = emp;

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
