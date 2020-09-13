using NTierApp.DataAccess.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NtierAppPresentationLayer.ViewModels
{
    public class VehicleVM
    {
        public string Color { get; set; }
        public Kind VehicleKind { get; set; }
        public string Type { get; set; }
        public string Mark { get; set; }
        public double Price { get; set; }
        public string Currency { get; set; } = "USD";
        public string ImgUrl { get; set; }
    }
}
