﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationApp.Web.DTOs
{
    public class EventDateDto
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
    }
}
