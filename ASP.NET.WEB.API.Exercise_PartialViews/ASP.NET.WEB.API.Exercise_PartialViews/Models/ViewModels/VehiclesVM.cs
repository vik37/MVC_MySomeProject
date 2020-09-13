using ASP.NET.WEB.API.Exercise_PartialViews.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET.WEB.API.Exercise_PartialViews.Models.ViewModels
{
    public class VehiclesVM
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        public string Color { get; set; }
        [Display (Name = "Vehicle Kind")]
        public Kind VehicleKind { get; set; }
        public string Type { get; set; }
        public string Mark { get; set; }
        public double Price { get; set; }
        public string Currency { get; set; }
        public string ImgUrl { get; set; }
        
    }
}
