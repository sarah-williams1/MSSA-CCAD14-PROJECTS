namespace Assignment_5._1._2_Sum_of_Individual_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate the sum of the individual digits given a number.\n");
            Console.WriteLine("Example: Given the number 1234, the sum output should be 10 because 1+2+3+4 = 10");
            Console.Write("The number is: ");
            string digitsInput = Console.ReadLine();
            double integerInput = Convert.ToDouble(digitsInput);

            double sum = 0;
            for (double i = 0; i < integerInput; i++)
            {
                sum += integerInput;
            }
            Console.WriteLine($"The sum of each integer is: {sum}");
        }
        
    }
}
