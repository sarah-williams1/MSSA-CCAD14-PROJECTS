namespace Assignment_1._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point();
            Point point2 = new Point();
 // Point is a custom data type that I defined in the method below.
 // point1 is the variable name
 // point2 is the other variable name
 // if else statement compares the two values and prints a text depending on the result.
            if (point1.x == point2.x)
            {
                Console.WriteLine("Points are on the same axis.");
            }
            else
            {
                Console.WriteLine("Point is not on the same axis");
            }

        }

    public struct Point 
    {
 // struct Point is the method
 // Point is also a custom data type

       public double x;
       public double y;


     }        


        
    }
}
