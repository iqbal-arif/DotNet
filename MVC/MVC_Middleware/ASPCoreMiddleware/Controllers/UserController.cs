using Microsoft.AspNetCore.Mvc;

namespace ASPCoreMiddleware.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
