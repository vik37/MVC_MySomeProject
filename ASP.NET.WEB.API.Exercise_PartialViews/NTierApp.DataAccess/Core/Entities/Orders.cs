using System;
using System.Collections.Generic;
using System.Text;

namespace NTierApp.DataAccess.Core.Entities
{
    public class Orders : BaseEntity
    {
        public bool isRented { get; set; }
        public DateTime Today { get; set; } = DateTime.Now;
        public DateTime ? RentDate { get; set; }
        public int ? Days  { get; set; }
        public List<Vehicles> Vehicles { get; set; }
        public Users User { get; set; }
    }
}
