using Microsoft.AspNetCore.Mvc;
using Organic.BusinnesLayer.Abstract;
using System.Diagnostics.Contracts;

namespace Organic.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultSecondSliderSectionComponentPartial : ViewComponent
    {
        private readonly IProductService _productService;

        public _DefaultSecondSliderSectionComponentPartial(IProductService productService)
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
