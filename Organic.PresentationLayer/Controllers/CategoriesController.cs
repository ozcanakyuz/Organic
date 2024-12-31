using Microsoft.AspNetCore.Mvc;
using Organic.BusinnesLayer.Abstract;
using Organic.EntityLayer.Concrete;

namespace Organic.PresentationLayer.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult CategoryList()
        {
            var values = _categoryService.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            if (bool.TryParse(Request.Form["CategoryStatus"], out bool status))
            {
                category.CategoryStatus = status;
            }
            else
            {
                category.CategoryStatus = false;
            }

            _categoryService.TInsert(category);
            return RedirectToAction("CategoryList");
        }

        public IActionResult DeleteCategory(int id)
        {
            _categoryService.TDelete(id);
            return RedirectToAction("CategoryList");
        }
    }
}
