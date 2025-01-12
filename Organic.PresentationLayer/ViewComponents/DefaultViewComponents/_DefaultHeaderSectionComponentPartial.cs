using Microsoft.AspNetCore.Mvc;

namespace Organic.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultHeaderSectionComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
