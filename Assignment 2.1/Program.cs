
namespace Assignment_2._1
{


    internal class Program
    {

        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.StudentID = 1;
            student1.StudentFirstName = "John";
            Console.WriteLine("Student ID is: " + student1.StudentID);
            Console.WriteLine("Student first name is: " + student1.StudentFirstName);

            
        }
    }


    public class Student // Safer code because the data validation is built into the code itself
    {
        private int _studentID;                          // Field
        private string _studentFirstName;                // Field
        private string _studentLastName;                 // Field
        private char _studentGrade;                      // Field

        public int StudentID                             // Property created the old fashioned way
        {
            get { return _studentID; }                   // Manually assigned get and set
            set { _studentID = value; }                  // value is the conventional name for when you don't have perameters
        }
        public string StudentFirstName                   // Property
        {
            get { return _studentFirstName; }
            set { _studentFirstName = value; }
        }

        public string StudentLastName                    // Property
        {
            get { return _studentLastName; }
            set { _studentLastName = value; }
        }
        public char StudentGrade                         // Property
        {
            get { return _studentGrade; }
            set { _studentGrade = value; }
        }

    }

    static public class SimpleMath
    {
        static public int Add(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }
        static public decimal Add(decimal numberOne, decimal numberTwo, decimal numberThree)
        {
            return numberOne + numberTwo + numberThree;
        }
        static public float Multiply(float numberOne, float numberTwo)
        {
            return numberOne * numberTwo;
        }
        static public float Multiply(float numberOne, float numberTwo, float numberThree)
        {
            return (numberOne * numberTwo * numberThree);
        }
    }
}
