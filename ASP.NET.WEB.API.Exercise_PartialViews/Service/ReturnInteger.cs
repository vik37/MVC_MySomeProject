using Service.IntegerService;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Service
{
    public static class ReturnInteger
    {
        public static int ReturnAges(DateTime dateOFBirth)
        {
           return AgeService.ReturnAge(dateOFBirth);
        }
    }
}
