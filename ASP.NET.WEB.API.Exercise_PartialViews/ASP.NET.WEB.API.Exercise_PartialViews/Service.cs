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
            int Age;
            DateTime today = DateTime.Today;
            if (today.Month < dateOfBirth.Month)
            {
                return Age = today.Year - dateOfBirth.Year - 1;
            }
            else
            {
                return Age = today.Year - dateOfBirth.Year;
            }
        }
    }
}
