using Microsoft.AspNetCore.Mvc;
using System.Runtime.Intrinsics.X86;

namespace ASPCoreMiddleware.Controllers
{
    //[Route("Home")] //Used on Controller level to avoid repeatation
    //Token Method
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        //ATTRIBUTE ROUTING
        //Defining Empty Route Attribute
        [Route("")]
        //[Route("Index")] //use when toke is not defined
        [Route("~/")] //Route for non specified route
        [Route("~/Home")] //Route for non specified route
        public IActionResult Index()
        {
            return View();
        }
        
        //[Route("About")]//use when token is not define
       
        public IActionResult About()
        {
            return View();
        }
        //[Route("ContactUs")]//use when token is not define
        
        public IActionResult ContactUs()
        {
            return View();
        }
        //use when token is not define
        //[Route("Details/{id?}")] //setting id as optional
        [Route("{id?}")] 
        public int Details(int? id) //Nulifying the id param
        {
            return id ?? 2;
        }
    }
}
