using Microsoft.AspNetCore.Mvc;

namespace Organic.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
    public class _MainPanelLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
