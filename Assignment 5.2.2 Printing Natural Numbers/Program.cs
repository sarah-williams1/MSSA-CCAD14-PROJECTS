namespace Assignment_5._2._2_Printing_Natural_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will print out the first n number of natural integers through the power of recurssion.");
            Console.WriteLine("Please type the number of numbers you'd like to see here: ");
            string numberToPrint = Console.ReadLine();
            int numberToReturn = Convert.ToInt32(numberToPrint);
            NaturalNumber(numberToReturn);
        }

        static void NaturalNumber(int numberToReturn)
        {
            if (numberToReturn < 1)
            {
                return;
            }
            NaturalNumber(numberToReturn - 1);
            Console.Write(" " + numberToReturn);
        }
    }
}
