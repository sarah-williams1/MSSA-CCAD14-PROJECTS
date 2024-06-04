namespace Assignment_5._2._2_Printing_Natural_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will print out the first n number of natural integers through the power of recurssion. The numbers will be printed in reverse!");
            Console.WriteLine("Please type the number of numbers you'd like to see here: ");
            string numberToPrint = Console.ReadLine();
            Console.WriteLine();
            int numberToReturn = Convert.ToInt32(numberToPrint);
            NaturalNumber(numberToReturn);
        }

        static void NaturalNumber(int numberToReturn)
        {
            if (numberToReturn < 1)
            {
                return;
            }
            Console.Write(numberToReturn+" ");
            NaturalNumber(numberToReturn - 1);
        }
    }
}
