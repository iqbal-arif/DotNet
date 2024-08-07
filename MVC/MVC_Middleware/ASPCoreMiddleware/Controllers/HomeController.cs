using Microsoft.AspNetCore.Mvc;

namespace ASPCoreMiddleware.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult About()
        {
            return View();
        }
        public int Details(int id)
        {
            return id;
        }
    }
}
