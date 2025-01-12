using Microsoft.AspNetCore.Mvc;
using Organic.BusinnesLayer.Abstract;

namespace Organic.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultFirstSliderSectionComponentPartial : ViewComponent
    {
        private readonly ISliderService _sliderService;

        public _DefaultFirstSliderSectionComponentPartial(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _sliderService.TGetAll();
            return View(values);
        }
    }
}
