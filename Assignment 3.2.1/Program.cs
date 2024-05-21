namespace Assignment_3._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] my2DArray = { { 1, 2, 3 }, { 4, 5, 6 } };
            // int i represents the first dimension of the array (the rows)
            // int j represents teh second dimension of the array (the collumns)
            for(int i = 0; i <my2DArray.GetLength(0); i++)
            {
                for (int j = 0; j<my2DArray.GetLength(1); j++)
                {
                    Console.Write("|");
                    Console.Write(my2DArray[i,j]);
                }

                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine($"\n {my2DArray[1, 2]}");
            // Should print out "6" because 6 is in index row 1 and index collumn 2
        }
    }
}
