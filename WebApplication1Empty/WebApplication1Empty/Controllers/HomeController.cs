using Microsoft.AspNetCore.Mvc;

namespace WebApplication1Empty.Controllers
{
    //[Route("[controller]")]
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        //[Route("/")]
        //[Route("home")]
        //[Route("home/index")]
        //public IActionResult Data()
        //{
        //    return View("~/Views/Home/Index.cshtml");
        //}
        [Route("")]
        //[Route("[action]")]
        //[Route("home")]
        //[Route("home/index")]
        [Route("~/")] //represent the there is no route
        [Route("~/Home")]
        public IActionResult Index()
        {
            return View();
        }


        //[Route("home/about")]
         //[Route("[action]")]
        public IActionResult About()
        {
            return View();
        }
        //[Route("home/details/{id?}")]
        //[Route("[action]/{id?}")]
        [Route("/{id?}")]
        public int Details(int? id)
        {
            return id ?? 1;
        }
    }
}
