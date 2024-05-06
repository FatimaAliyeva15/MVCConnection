using Microsoft.AspNetCore.Mvc;

namespace MVCConnect.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
