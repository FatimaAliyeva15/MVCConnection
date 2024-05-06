using Microsoft.AspNetCore.Mvc;

namespace MVCConnect.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
