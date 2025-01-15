using Microsoft.AspNetCore.Mvc;

namespace Organic.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultSignUpBannerSectionComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
