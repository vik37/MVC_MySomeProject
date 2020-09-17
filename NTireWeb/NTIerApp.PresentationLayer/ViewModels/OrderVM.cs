using EntireApp.DataAcess.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTIerApp.PresentationLayer.ViewModels
{
    public class OrderVM
    {
        public UserVM User { get; set; }
        public List<MoviesVM> Movies { get; set; }
    }
}
