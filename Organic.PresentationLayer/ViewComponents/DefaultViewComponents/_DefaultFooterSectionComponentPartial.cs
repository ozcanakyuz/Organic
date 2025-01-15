using Microsoft.AspNetCore.Mvc;

namespace Organic.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultFooterSectionComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
