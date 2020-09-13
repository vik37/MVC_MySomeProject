using ASP.NET.WEB.API.Exercise_PartialViews.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET.WEB.API.Exercise_PartialViews.Models.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }        
        public Gender Gender { get; set; }
        public Entitie Entitie { get; set; }
        public DateTime BirthDay { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }
        public long Phone { get; set; }
        public int IDCardNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User()
        {
            Age = Service.ReturnAges(BirthDay);
        }
        
    }
}
