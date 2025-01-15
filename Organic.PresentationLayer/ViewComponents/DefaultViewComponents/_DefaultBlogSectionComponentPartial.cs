using Microsoft.AspNetCore.Mvc;
using Organic.BusinnesLayer.Abstract;

namespace Organic.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultBlogSectionComponentPartial : ViewComponent
    {
        private readonly IBlogService _blogService;

        public _DefaultBlogSectionComponentPartial(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _blogService.TGetAll();
            return View(values);
        }
    }
}
