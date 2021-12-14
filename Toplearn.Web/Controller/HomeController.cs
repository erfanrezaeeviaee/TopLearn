using Microsoft.AspNetCore.Mvc;

namespace Toplearn.Web.Controller
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}