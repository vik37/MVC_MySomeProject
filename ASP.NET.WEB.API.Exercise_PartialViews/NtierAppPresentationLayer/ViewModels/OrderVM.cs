using NTierApp.DataAccess.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NtierAppPresentationLayer.ViewModels
{
    public class OrderVM
    {
        public bool isRented { get; set; }
        public DateTime Today { get; set; } = DateTime.Now;
        public DateTime? RentDate { get; set; }
        public int? Days { get; set; }
        public List<VehicleVM> Vehicles { get; set; }
        public UserVM User { get; set; }
    }
}
