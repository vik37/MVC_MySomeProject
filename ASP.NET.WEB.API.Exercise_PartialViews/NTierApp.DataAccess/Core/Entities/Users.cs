using NTierApp.DataAccess.Core.Enums;
using System;
using System.Collections.Generic;

using System.Text;

namespace NTierApp.DataAccess.Core.Entities
{
    public class Users : BaseEntity
    {
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
        public List<Orders> Orders { get; set; }

        
    }
}
