﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Organic.BusinnesLayer.Abstract;
using Organic.DtoLayer.Dtos.AboutDtos;
using Organic.EntityLayer.Concrete;

namespace Organic.PresentationLayer.Controllers
{
    public class AboutsController : Controller
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public AboutsController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        public IActionResult AboutList()
        {
            var values = _aboutService.TGetAll();
            return View(_mapper.Map<List<ResultAboutDto>>(values));
        }
        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto)
        {
            var values = _mapper.Map<About>(createAboutDto);
            _aboutService.TInsert(values);
            return RedirectToAction("AboutList");
        }
        public IActionResult DeleteAbout(int id)
        {
            _aboutService.TDelete(id);
            return RedirectToAction("AboutList");
        }
        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var value = _aboutService.TGetById(id);
            return View(_mapper.Map<GetByIdAboutDto>(value));
        }
        [HttpPost]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            var value = _mapper.Map<About>(updateAboutDto);
            _aboutService.TUpdate(value);
            return RedirectToAction("AboutList");
        }
    }
}
