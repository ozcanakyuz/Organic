using Microsoft.AspNetCore.Mvc;

namespace Organic.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultHeadSectionComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
