// Write a base class called Shape and add other classes and properties

namespace Assignment_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello human, tell me...which shape are you thinking of? Square or Circle. \nType C for circle and S for square");
            string chosenShape = Console.ReadLine();
            Console.WriteLine();
            
            
            switch(chosenShape)
            {
                case "S":
                case "s":
                    Console.WriteLine("What is the side length?");
                    double squareSideLength = Convert.ToDouble(Console.ReadLine());
                    Square mySquare = new Square();
                    mySquare.CalculateArea(squareSideLength);
                    Console.WriteLine();
                    break;
                case "C":
                case "c":
                    Console.WriteLine("What is the radius length?");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Circle myCircle = new Circle();
                    myCircle.CaluclateArea(radius);
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Beep boop beep. Invalid response. Program shutting down. Beep boop beep.");
                    break;
            }

            Console.WriteLine("That's a wonderful shape, what color is it?\nR for Red\nG for Green\nB for Blue");
            string colorValue = Console.ReadLine();
            Console.WriteLine();

            switch(colorValue)
            {
                case "r":
                case "R":
                    Console.WriteLine("Congratulations! Your shape is now red!!!\nBut...green would have been a better choice.");
                    break;
                case "B":
                case "b":                    
                    Console.WriteLine("Congratulations! Your shape is now  is now blue!!!\nBut...green would have been a better choice.");
                    break;
                case "g":
                case "G":
                    Console.WriteLine("Congratulations! Your shape is now the super awesome color....GREEN!!!");
                    break;
                default:
                    Console.WriteLine("Beep boop beep. Invalid response. Program shutting down. Beep boop beep.");
                    break;
            }



        }
    }
    public enum ColorValue { Red, Blue, Green }
    public abstract class Shape // Base Class
    {
        public string ShapeID { get; set; }
        public string ShapeName { get; set; }
        public string ShapeDescription { get; set; }
        public ColorValue ShapeColor { get; set; }
        public virtual void CalculateArea() 
        {
            Console.WriteLine("The area of the shape is: undefined");
        }
    }

    public class Square : Shape // Child Class
    {
        public double SquareSideLength { get; set; } // Property
        public void CalculateArea(double squareSideLength) // Parameter
        {
            SquareSideLength = squareSideLength; // Sets the property
            Console.WriteLine( "The area of the square is: " + Math.Pow(SquareSideLength, 2));
        }
       
    }
        public class Circle : Shape // Child Class
    {
        public double Radius { get; set; } // Property
        public void CaluclateArea(double radius) // Parameter
        {
            Console.WriteLine("The area of the circle is: " + Math.PI * Math.Pow(radius, 2));
        }
    }
}
