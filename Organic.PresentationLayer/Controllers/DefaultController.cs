using Microsoft.AspNetCore.Mvc;

namespace Organic.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
