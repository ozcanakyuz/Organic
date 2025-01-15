using Microsoft.AspNetCore.Mvc;
using Organic.BusinnesLayer.Abstract;
using Organic.EntityLayer.Concrete;

namespace Organic.PresentationLayer.Controllers
{
    public class BlogsController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogsController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IActionResult BlogList()
        {
            var values = _blogService.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateBlog()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateBlog(Blog blog)
        {
            _blogService.TInsert(blog);
            return RedirectToAction("BlogList");
        }

        [HttpGet]
        public IActionResult UpdateBlog(int id)
        {
            var values = _blogService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateBlog(Blog blog)
        {
            _blogService.TUpdate(blog);
            return RedirectToAction("BlogList");
        }
        public IActionResult DeleteBlog(int id)
        {
            _blogService.TDelete(id);
            return RedirectToAction("BlogList");
        }

    }
}
