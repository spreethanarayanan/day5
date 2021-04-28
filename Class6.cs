using System;
using System.Collections.Generic;
using System.Text;

namespace day5
{
    class Class6
    {
        public static void Main()
        {
            DateTime dob = Convert.ToDateTime("15/05/1998");
            int age = CalculateAge(dob);
        }
        private static int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }

    }
}
