using System;
using MultiplyStringsDomain.Models;

namespace MultiplyStringsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = "2";
            var number2 = "3";
            string result = SuperInteger.MultiplyStrings(number1, number2);

            Console.WriteLine($"The result of multiply {number1} * {number2} is {result}");
        }
    }
}
