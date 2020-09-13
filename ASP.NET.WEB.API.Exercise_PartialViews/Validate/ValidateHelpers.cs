using System;

namespace Validate
{
    public static class ValidateHelpers
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
