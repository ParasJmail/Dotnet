using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PassData.Models;

namespace PassData.Controllers
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
            ViewData["data1"] = "View Data";
            ViewBag.data2 = "View Bag";
            TempData["data3"] = "Temp Data";
            //ViewBag.data1 = "Paras";
            //ViewBag.data2 = 25;
            //ViewBag.data3 = DateTime.Now.ToShortDateString();
            //string[] arr = { "Paras", "Ranjana", "Paavan" };
            //ViewBag.data4 = arr;
            //ViewBag.data5 = new List<string>()
            //{
            //    "Cricket", "Football", "Hockey"
            //};
            //ViewData["data1"] = "Paras";
            //ViewData["data2"] = 25;
            //ViewData["data3"] = DateTime.Now.ToLongDateString();
            //string[] arr = { "Paras", "Paavan", "Iti" };
            //ViewData["data4"] = arr;
            //ViewData["data5"] = new List<string>()
            //{
            //    "Cricket", "FootBall", "Kabbadi"
            //};
            return View();
        }
        
        public IActionResult About()
        {
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
