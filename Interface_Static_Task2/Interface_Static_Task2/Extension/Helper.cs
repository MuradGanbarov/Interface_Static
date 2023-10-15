//TASK 2

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Interface_Static_Task2.Extension
{
    public static class Helper
    {

        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;

        }

        public static bool IsEven(this int digit)
        {
            return digit % 2 == 0;
        }


        public static bool HasDigit(this string str)
        {

            return Regex.IsMatch(str, @"\d");
        }

        public static bool CheckPassword(this string password)
        {
            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";
            return Regex.IsMatch(password, passwordPattern);

        }

        public static string Capitalize(this string str)
        {
            if (string.IsNullOrEmpty(str)) return str;

            return char.ToUpper(str[0]) + str.Substring(1);
        }

    }
}
