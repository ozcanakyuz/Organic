using Microsoft.AspNetCore.Mvc;
using Organic.BusinnesLayer.Abstract;
using Organic.DataAccessLayer.Context;

namespace Organic.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultPopularProductSectionComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using (OrganicContext db = new OrganicContext())
            {
                // En pahalı 9 ürünü getir
                var topExpensiveProducts = db.Products
                    .OrderByDescending(x => x.Price) // Fiyata göre azalan sırayla sırala
                    .Take(9)                         // İlk 9 ürünü al
                    .ToList();

                return View(topExpensiveProducts);
            }
        }
    }
}
