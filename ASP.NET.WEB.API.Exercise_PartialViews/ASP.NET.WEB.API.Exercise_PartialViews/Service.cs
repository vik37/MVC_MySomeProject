using ASP.NET.WEB.API.Exercise_PartialViews.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET.WEB.API.Exercise_PartialViews
{
    public static class Service
    {
        public static int ReturnAges(DateTime dateOfBirth)
        {
            int age;
            DateTime today = DateTime.Today;
            if (today.Month < dateOfBirth.Month)
            {
                age = today.Year - dateOfBirth.Year - 1;
            }
            else
            {
                age = today.Year - dateOfBirth.Year;
            }
            return age;
        }
    }
}
