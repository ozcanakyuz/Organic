using Microsoft.AspNetCore.Mvc;
using Organic.BusinnesLayer.Abstract;
using Organic.EntityLayer.Concrete;

namespace Organic.PresentationLayer.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult ProductList()
        {
            var values = _productService.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            _productService.TInsert(product);
            return RedirectToAction("ProducTList");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var values = _productService.TGetById(id);
            return View(values);
        }
        public IActionResult UpdateProduct(Product product)
        {
            _productService.TUpdate(product);
            return RedirectToAction("ProductList");
        }

        public IActionResult DeleteProduct(int id)
        {
            _productService.TDelete(id);
            return RedirectToAction("ProductList");
        }
    }
}
