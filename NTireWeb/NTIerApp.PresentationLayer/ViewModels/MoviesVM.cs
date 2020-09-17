using EntireApp.DataAcess.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTIerApp.PresentationLayer.ViewModels
{
    public class MoviesVM
    {
        public string Title { get; set; }
        public string Duration { get; set; }
        public Rating MovieRating { get; set; }
        public Genre MovieGenre { get; set; }
    }
}
