using Microsoft.AspNetCore.Mvc;

namespace ASPCoreMiddleware.Controllers
{
    public class ContactUs : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
