namespace Assignment_5._3._2_Fibonacci_Stairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You are climbing a staircase and it takes \"n\" number of steps to reach the top.\nYou can take either 1 or 2 steps at a time. How many ways can you climb to the top?");
            Console.WriteLine();
            Console.WriteLine("Enter the number of steps in the staircase:");
            string n = Console.ReadLine();
            int numberOfSteps = Convert.ToInt32(n);
            int totalCombinations = FibonacciCalculation(numberOfSteps);
            Console.WriteLine($"The staircase has {n} steps. There are {totalCombinations} combinations of steps to reach the top of the staircase.");
        }

        public static int FibonacciCalculation(int numberOfSteps)
        {
            if (numberOfSteps < 2)
                return numberOfSteps;

            // fibonacciiSequence = "F(n) = F(n-1) + F(n-2)";
            
            int x = (numberOfSteps - 1) + (numberOfSteps - 2);
            return x;
        }
    }
}

/* line 10. string n is the number of steps. 
line 11. int numberOfSteps is the number of steps in integer format.
line 12. the FibonacciCalculation method is assigned to the totalCombinations variable and performs the calculation.

lines 12 + 16. The FibonacciCalculation method uses the variable "numberOfSteps" to solve for x.
line 23. int x is the value for the total combinations.
line 24. return x sends the data from the method to the variable int totalCombinations.
*/
