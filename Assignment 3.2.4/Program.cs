using System.Diagnostics.CodeAnalysis;

namespace Assignment_3._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Requesting user input
            Console.WriteLine("This program will take the sum and the average values of 4 numbers.\nPlease enter the first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the third number: ");
            double thirdNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the fourth number: ");
            double fourthNumber = Convert.ToDouble(Console.ReadLine());

            double[] numberedArray = { firstNumber, secondNumber, thirdNumber, fourthNumber };
            // Calling the method to do the calculations
            // The output of the method is assigned to the returnArray array.
            // The values are printed on the console. [0] is the sum and [1] is the average values.
            double[] returnArray = TotalAndAverageValues(numberedArray);
            Console.WriteLine($"The sum is {returnArray[0]} and the avareage is {returnArray[1]}.");

                        
        }
        static double[] TotalAndAverageValues(double[] methodNumberedArray)
        {
            double sumTotal = methodNumberedArray[0] + methodNumberedArray[1] + methodNumberedArray[2] + methodNumberedArray[3];
            double averageValue = sumTotal / 4;
            double[] outputArray = [sumTotal,  averageValue];
            return outputArray;
        }
    }
}
