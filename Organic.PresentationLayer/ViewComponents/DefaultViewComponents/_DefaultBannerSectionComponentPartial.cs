using Microsoft.AspNetCore.Mvc;

namespace Organic.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultBannerSectionComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
