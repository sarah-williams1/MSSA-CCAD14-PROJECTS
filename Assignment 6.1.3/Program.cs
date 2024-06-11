namespace Assignment_6._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] numsArray = { 0, 1, 0, 3, 1, 2 };
            Console.WriteLine("Given the array { 0, 1, 0, 3, 1, 2}, move all the 0's to the end without making a copy of the array.");
            Console.WriteLine(string.Join(", ", numsArray));

            int j = 0;
            for (int i = 0; i < numsArray.Length; i++)
            {
                if (numsArray[i] != 0)
                {
                    numsArray[j++] = numsArray[i];

                }
            }

            for (int i = 0; i == j; i++)
            {
                numsArray[numsArray.Length - 1 - i] = 0;
            }

        }       
    }
}
