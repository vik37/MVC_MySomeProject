using System;
using System.Collections.Generic;
using System.Text;

namespace Service.IntegerService
{
    internal static class AgeService
    {
        public static int ReturnAge(DateTime dateOfBith)
        {
            int Age = 0;
            DateTime toDay = DateTime.Today;
            if (toDay.Month < dateOfBith.Month)
            {
                 Age = toDay.Year - dateOfBith.Year - 1;
            }
            return Age;
        }
    }
}
