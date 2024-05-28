using Microsoft.AspNetCore.Mvc;

namespace USKT_Community.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
