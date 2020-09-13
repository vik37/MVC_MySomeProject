using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET.WEB.API.Exercise_PartialViews.Models.Domain
{
    public class Orders
    {
        public int Id { get; set; }
        public bool isRented { get; set; }
        public DateTime RentDate { get; set; }
        public int Days { get; set; }
        public Vehicles vehicles { get; set; }
        public User user { get; set; }
    }
}
