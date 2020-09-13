using ASP.NET.WEB.API.Exercise_PartialViews.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET.WEB.API.Exercise_PartialViews.Models.Domain
{
    public class Vehicles
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public Kind VehicleKind { get; set; }
        public string Type { get; set; }
        public string Mark { get; set; }
        public double Price { get; set; }
        public string Currency { get; set; } = "USD";
        public string ImgUrl { get; set; }

    }
}
