﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organic.DtoLayer.Dtos.SliderDtos
{
    public class GetByIdSliderDto
    {
        public int SliderId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
    }
}
