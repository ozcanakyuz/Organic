using Microsoft.AspNetCore.Mvc;
using Organic.BusinnesLayer.Abstract;

namespace Organic.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultProductSectionComponentPartial : ViewComponent
    {
        private readonly IProductService _productService;

        public _DefaultProductSectionComponentPartial(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _productService.TGetAll();
            return View(values);
        }
    }
}
