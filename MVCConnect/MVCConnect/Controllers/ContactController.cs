using Microsoft.AspNetCore.Mvc;

namespace MVCConnect.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
