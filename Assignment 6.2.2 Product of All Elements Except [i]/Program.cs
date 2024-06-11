using System.Numerics;

namespace Assignment_6._2._2_Product_of_All_Elements_Except__i_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiply all elements together, except for the i'th element.\n\n");
            int[] firstProductArray = { 1, 2, 3, 4 };
            int[] secondProductArray = { -1, 1, 0, -3, 3 };
            int[] result = FirstProductCalculation(firstProductArray);              // output should be { 24, 12, 8, 6 }
            int[] secondResult = SecondProductCalculation(secondProductArray);      // output should be { 0, 0, 9, 0, 0 }

            Console.WriteLine("The first array is: { " + string.Join(", ", firstProductArray) + " }");
            Console.WriteLine("The resulting product array is: { " + string.Join(", ", result) + " }");

            Console.WriteLine(" ");

            Console.WriteLine("The product for the second array was calculated without using the division operator.");
            Console.WriteLine("The second array is : { " + string.Join(", ", secondProductArray) + " }");
            Console.WriteLine("The resulting array is: { " + string.Join(", ", secondResult) + " }");
        }

        internal static int[] FirstProductCalculation(int[] firstProductArray) // This method uses the division operator. It multiplies all the elements, then divides by i. 
        {
            int[] firstResultArray = new int[firstProductArray.Length];
            int product = 1;

            for (int i = 0; i < firstProductArray.Length; i++)
            {
                product *= firstProductArray[i];
            }
            for (int i = 0; i < firstProductArray.Length; i++)
            {
                if (firstProductArray[i] != 0)
                {
                    firstResultArray[i] = product / firstProductArray[i];
                }
                else
                {
                    int productForZero = 1;
                    for (int j = 0; j < firstProductArray.Length; j++)
                    {
                        if (i != j)
                        {
                            productForZero *= firstProductArray[j];
                        }
                    }
                    firstProductArray[i] = productForZero;
                }
            }

            return firstResultArray;
        }

        internal static int[] SecondProductCalculation(int[] secondProductArray) // This method does not use the division operator.
        {
            int[] secondResultArray = new int[secondProductArray.Length];           // Establishes a new array as secondResultsArray, setting it equal to the length of secondProductArray.
            
            for (int i = 0; i < secondProductArray.Length; i++)                     // Tells the program to go through each iteration of the array secondProductArray
            {
                int product = 1;                                                    // Sets a variable called product equal to 1. This will hold the product for the operations. 
                for (int j = 0; j < secondProductArray.Length; j++)                 // Establishes a new iteration called j
                {
                    if (i != j)                                                     // If i and j are equal then it will not calculate the product.
                    {
                        product *= secondProductArray[j];
                    }
                }
                secondResultArray[i] = product;                                     // Sets the product as the value for each iteration, i
            }
            return secondResultArray;                                               // Returns the secondResultArray that contains the product of the elements in secondProductArray.
        }
    }
}
