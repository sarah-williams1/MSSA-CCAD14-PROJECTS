using System;
using System.Globalization;

namespace Assignment_3._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a year. This awesome program will check if it is a leap year or not a leap year.\n");
            string enteredYear = Console.ReadLine();

            int.TryParse(enteredYear, out int integerYear);
             if (DateTime.IsLeapYear(integerYear))
            {
                Console.WriteLine(integerYear + " is a leap year!\n\tDon't forget to leap for leap year!");
            }
             else
            {
                Console.WriteLine(integerYear + " is not a leap year\n\twomp womp");
            }
        }       
    }
}
