﻿using EntireApp.DataAcess.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntireApp.DataAcess.Core.Entities
{
    public class Movie : BaseEntity
    {
        public string  Title { get; set; }
        public string Duration { get; set; }
        public Rating MovieRating  { get; set; }
        public Genre MovieGenre { get; set; }


    }
}
