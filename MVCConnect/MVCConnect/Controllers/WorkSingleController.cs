using Microsoft.AspNetCore.Mvc;

namespace MVCConnect.Controllers
{
    public class WorkSingleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
