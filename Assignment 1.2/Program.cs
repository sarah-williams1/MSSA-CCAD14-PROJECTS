/* The purpose of this program is to take two integers and check whether they are equal or not.
 * The second part of this program will find the sum of the first 10 natural numbers.
 */


namespace Assignment_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The next two lines initializes the variables numberOne and numberTwo, giving them a value of 5. The data type is int (integer).
            int numberOne = 5;
            int numberTwo = 5;
            // These lines of code checks the values of the variables and uses an "if" statement to dispaly a message depending on the result.
            if (numberOne == numberTwo)
            {
                Console.WriteLine("They're the same! " + numberOne + " = " + numberTwo);
            }
            else
            {
                Console.WriteLine("They're not the same.");
            }

            // This part wil use a boolean expression to test the values.

            int numberThree = 5;
            int numberFour = 15;

            bool numbers = numberThree == numberFour;
            Console.WriteLine(numberThree + " does not equal " + numberFour);


            // ASSIGNMENT 1.2 PART TWO: Finding the sum of the first 10 natural numbers.
            // Initializing the integer "sum" at 0. The variable naturalNumber will add to sum until naturalNumber equals 10.
            // Creating a for loop to display the first 10 natural numbers.
            Console.WriteLine("The first 10 natural numbers are:");
            int sum = 0;

            /* This is a for loop to calculate the sum. The first part "int naturalNumber = 1" initializes the variable 'naturalNumber' starting value of 1.
             * The second part "naturalNumber <= 10" means that the variable 'naturalNumber' has a value less than or equal to 10.
             * The third part "naturalNumber++" tells the code to add 1 to the value of 'naturalNumber'.
             * The loop should continue until the value of 'number' is 10.
             */

            for (int naturalNumber = 1; naturalNumber <= 10; naturalNumber++) 
            {
                Console.Write(naturalNumber + " ");
                sum += naturalNumber;
            }
            // sum += number means that the value of 'sum' will increase by the value of 'naturalNumber'. The value will increase each time the code loops.
            Console.WriteLine("The sum of the first 10 natural numbers is: " + sum);
            
        }
    }
}
