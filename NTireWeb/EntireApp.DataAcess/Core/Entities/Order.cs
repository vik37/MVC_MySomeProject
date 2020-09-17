using System;
using System.Collections.Generic;
using System.Text;

namespace EntireApp.DataAcess.Core.Entities
{
    public class Order : BaseEntity
    {
        public User User { get; set; }
        public List<Movie> Movie { get; set; }

    }
}
