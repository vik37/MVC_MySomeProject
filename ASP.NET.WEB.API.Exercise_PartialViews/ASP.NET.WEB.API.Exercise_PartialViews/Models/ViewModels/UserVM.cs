using ASP.NET.WEB.API.Exercise_PartialViews.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET.WEB.API.Exercise_PartialViews.Models.ViewModels
{
    public class UserVM
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }       
        public Gender Gender { get; set; }
        public Entitie Entitie { get; set; }
    }
}
