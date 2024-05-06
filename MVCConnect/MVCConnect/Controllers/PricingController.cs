using Microsoft.AspNetCore.Mvc;

namespace MVCConnect.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
