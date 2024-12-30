using Microsoft.AspNetCore.Mvc;

namespace Organic.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
    public class _SidebarLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
