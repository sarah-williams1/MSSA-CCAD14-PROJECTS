namespace Assignment_7._1._1_Selection_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The presorted test scores");
            int[] testScore = { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10 };
            PrintMethod(testScore);

            TestScoresSorted(testScore);                            // Initializes the method, with the testScore array as the input
            Console.WriteLine("The test scores after being sorted in ascending order.");
            PrintMethod(testScore);
            
        }

        public static void TestScoresSorted(int[] scoreArray )      // method is static and void because the main method is static void.
        {
            int n = scoreArray.Length;                              // gives the variable n the value of scoreArray.Length
            for ( int i = 0; i < n - 1; i++)                        // int i starts at 0 and for each iteration of i being less than the length - 1, the loop iterates again
            {
                int indexMinimum = i;                               // the assumed minimum is given the value of i

                for ( int j = i + 1; j < n; j++ )                   // int j is equal to i + 1, and if it is less than the array length, the inner loop iterates again.
                {
                    if (scoreArray[j] < scoreArray[indexMinimum])   // if the current element in scoreArray[j] is less than the element at indexMinimum, indexMinimum takes the value of index j
                    {
                        indexMinimum = j;
                    }
                }

                int temp = scoreArray[indexMinimum];                // Checks if indexMinimum is different than i. If it is then a smaller element was found and the method swaps the element
                scoreArray[indexMinimum] = scoreArray[i];           // at indexMinimum with the element i.
                scoreArray[i] = temp;
            }
        }

        public static void PrintMethod(int[] scoreArray)
        {
            foreach (int score in scoreArray )
            {  Console.Write(score + " "); }
            Console.WriteLine("\n\n");
        }
    }
}
