using Microsoft.AspNetCore.Mvc;

namespace Organic.PresentationLayer.Controllers
{
    public class ErrorPagesController : Controller
    {
        public IActionResult ErrorPages404()
        {
            return View();
        }
    }
}
