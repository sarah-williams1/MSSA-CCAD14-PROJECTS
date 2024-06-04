namespace Assignment_5._2._1_Length_of_Last_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given a string consisting of words and spaces, return the length of the last word in the string.");
          
            string inputString ="Fly me to the moon";
            Console.WriteLine(inputString);
            string[] inputStringArray = inputString.TrimEnd().Split(' ');
            
            // int lastWordLength takes the length of the input string and subtracts 1.
            // This is because strings are arrays, and indexes start at 0.
            string lastWord = inputStringArray[inputStringArray.Length - 1];
            int lastWordLength = lastWord.Length;
            Console.WriteLine($"The length of the last word is: {lastWordLength}");          
        }
    }
}
