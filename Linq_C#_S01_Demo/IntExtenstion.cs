using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Linq_C__S01_Demo
{
    public static class IntExtension
    {
        public static int ReverseNumber( this int number)
        {
            // Convert the number to a string
            string numberStr = number.ToString();

            // Reverse the string
            char[] charArray = numberStr.ToCharArray();
            Array.Reverse(charArray);
            string reversedStr = new string(charArray);

            // Convert the reversed string back to an integer
            int reversedNumber = int.Parse(reversedStr);

            // Return the reversed integer
            return reversedNumber;
        }
    }
}
