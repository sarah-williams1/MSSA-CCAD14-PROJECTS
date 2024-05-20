using System.Text;


namespace Assignment_3._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int integerEvenNumber = 0;

            for (integerEvenNumber = 0; integerEvenNumber <= 101; integerEvenNumber += 2)
            {
                Console.WriteLine(" " + integerEvenNumber);
            }
            */

            
            StringBuilder evenNumber = new StringBuilder();
            for (int integerEvenNumber = 0; integerEvenNumber <= 101; integerEvenNumber += 2)
            {
                Console.WriteLine(integerEvenNumber.ToString());
            }
           
            Console.WriteLine(evenNumber);
        }
    }
}
