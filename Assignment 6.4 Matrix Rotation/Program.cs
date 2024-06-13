using System.Numerics;

namespace Assignment_6._4_Matrix_Rotation
{
    internal class Program
    {

        static int n = 3;

        static void Main(string[] args)
        {
            Console.WriteLine("This code will attempt to rotate a matrix 90 degrees.");
            char[,] matrix = { { 'a', 'b', 'c' }, { 'd', 'e', 'f' }, { 'g', 'h', 'k' } };

            // Transposing a matrix is when the rows become columns and columns become rows.
            // The formula is this: A^Tij=Aji

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " "); // prints the matrix as a matrix

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Rotate90Clockwise(matrix);
            Console.WriteLine();
            PrintMatrix(matrix);

        }

        static void Rotate90Clockwise(char[,] matrix)
        {
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n / 2; j++) {
                    char temp = matrix[i, j];
                    matrix[i, j] = matrix[n - 1 - j,i];
                    matrix[n - 1 - j, i] = matrix[n - 1 - i, n - 1 - j];
                    matrix[n - 1 - i, n - 1 - j] = matrix[j, n - 1 - i];
                    matrix[j, n - 1 - i] = temp;
                }
            }
        }

        static void PrintMatrix(char[,] arr)
        {
            for (int i= 0; i <n; i++)
            {
                for (int j = 0; j < n; j++)
                Console.Write(arr[i, j] + " ");
                Console.WriteLine();
            }
        }


    }
}

    