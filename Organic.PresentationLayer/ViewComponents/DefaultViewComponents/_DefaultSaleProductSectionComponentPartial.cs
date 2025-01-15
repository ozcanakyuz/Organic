using Microsoft.AspNetCore.Mvc;
using Organic.DataAccessLayer.Context;

namespace Organic.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultSaleProductSectionComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using (OrganicContext db = new OrganicContext())
            {
                // En ucuz 9 ürünü getir
                var topCheapProducts = db.Products
                    .OrderBy(x => x.Price) // Fiyata göre artan sırayla sırala
                    .Take(9)                         // İlk 9 ürünü al
                    .ToList();

                return View(topCheapProducts);
            }
        }
    }
}
