using Microsoft.AspNetCore.Mvc;

namespace Organic.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
    public class _FooterLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
