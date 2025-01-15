using Microsoft.AspNetCore.Mvc;
using Organic.DataAccessLayer.Context;

namespace Organic.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultProductSectionComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using (OrganicContext db = new OrganicContext())
            {
                var tenProducts = db.Products
                    .Take(10)
                    .ToList();

                return View(tenProducts);
            }
        }
    }
}
