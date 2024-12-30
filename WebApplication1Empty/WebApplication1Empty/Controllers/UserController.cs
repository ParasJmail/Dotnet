using Microsoft.AspNetCore.Mvc;

namespace WebApplication1Empty.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
