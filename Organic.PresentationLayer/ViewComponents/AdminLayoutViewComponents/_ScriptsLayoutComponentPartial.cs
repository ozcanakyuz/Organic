using Microsoft.AspNetCore.Mvc;

namespace Organic.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
    public class _ScriptsLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
