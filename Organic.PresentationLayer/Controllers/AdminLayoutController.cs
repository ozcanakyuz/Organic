using Microsoft.AspNetCore.Mvc;

namespace Organic.PresentationLayer.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
