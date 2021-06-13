using System.Collections.Generic;

namespace MultiplyStringsDomain.Models
{
    public class SuperInteger
    {
        /// <summary>Takes two string numbers and multiplies them</summary>
        /// <param name="number1">First number</param>
        /// <param name="number2">Second number</param>
        /// <returns>Integer</returns>
        public static string MultiplyStrings(string number1, string number2)
        {
            var n1 = 0;
            var n2 = 0;

            var dictionary = new Dictionary<char, int>
            {
                {'0', 0},
                {'1', 1},
                {'2', 2},
                {'3', 3},
                {'4', 4},
                {'5', 5},
                {'6', 6},
                {'7', 7},
                {'8', 8},
                {'9', 9}
            };

            foreach (char digit in number1)
            {
                n1 = 10 * n1 + dictionary.GetValueOrDefault(digit);
            }

            foreach (char digit in number2)
            {
                n2 = 10 * n2 + dictionary.GetValueOrDefault(digit);
            }

            return (n1 * n2).ToString();
        }
    }
}