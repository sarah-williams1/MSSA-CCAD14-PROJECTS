using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Assignment_5._1._1_Integer_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given an integer x, return true if x is a palindrome and false if it is not.");
            Console.WriteLine();
            Console.WriteLine("Example:\nInput: x = 121\tOutput: true\nInput: x = -121\tOutput: false");

            Console.Write("Please type the number here:");
            string userInput = Console.ReadLine();

            bool output = Output(userInput);
            Console.WriteLine($"{output}");

            //string userOutput;
            //if (userInput == userInput.Reverse())
            //{
            //    userOutput = "true";
            //    Console.WriteLine(userOutput);
            //}
            //else
            //{
            //    userOutput = "false";
            //    Console.WriteLine(userOutput);
            //}
        }

        public static bool Output(string userInput)
        {
            return userInput == new string(userInput.Reverse().ToArray());
        }
    }
}
