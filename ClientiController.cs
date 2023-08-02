using Microsoft.AspNetCore.Mvc;

namespace DemoAPI.Controllers
{
    public class ClientiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
