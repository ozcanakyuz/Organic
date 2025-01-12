using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Organic.BusinnesLayer.Abstract;
using Organic.DtoLayer.Dtos.SliderDtos;
using Organic.EntityLayer.Concrete;

namespace Organic.PresentationLayer.Controllers
{
    public class SlidersController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly IMapper _mapper;

        public SlidersController(ISliderService sliderService, IMapper mapper)
        {
            _sliderService = sliderService;
            _mapper = mapper;
        }

        public IActionResult SliderList()
        {
            var values = _sliderService.TGetAll();
            return View(_mapper.Map<List<ResultSliderDto>>(values));
        }
        [HttpGet]
        public IActionResult CreateSlider()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSlider(CreateSliderDto createSliderDto)
        {
            var value = _mapper.Map<Slider>(createSliderDto);
            _sliderService.TInsert(value);
            return RedirectToAction("SliderList");
        }
        public IActionResult DeleteSlider(int id)
        {
            _sliderService.TDelete(id);
            return RedirectToAction("SliderList");
        }
        [HttpGet]
        public IActionResult UpdateSlider(int id)
        {
            var value = _sliderService.TGetById(id);
            return View(_mapper.Map<GetByIdSliderDto>(value));
        }

        [HttpPost]
        public IActionResult UpdateSlider(UpdateSliderDto updateSliderDto)
        {
            var value = _mapper.Map<Slider>(updateSliderDto);
            _sliderService.TUpdate(value);
            return RedirectToAction("SliderList");
        }
    }
}
