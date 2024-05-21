// Creating a matrix that adds the values of the first and second arrays.

namespace Assignment_3._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] myFirst2DArray = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] mySecond2DArray = { { 5, 6, 7 }, { 7, 8, 9 } };
            // int i represents the first dimension of the array (the rows)
            // int j represents the second dimension of the array (the collumns)
            for (int i = 0; i < myFirst2DArray.GetLength(0); i++)
            {
                for (int j = 0; j < myFirst2DArray.GetLength(1); j++)
                {
                    Console.Write("|");
            // row below prints the sum
                    Console.Write(myFirst2DArray[i, j] + mySecond2DArray[i, j]);
                }

                Console.Write("|");
                Console.WriteLine();
            }
        }
    }
}
