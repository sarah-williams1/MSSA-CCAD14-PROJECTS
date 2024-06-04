namespace Assignment_5._2._4_Palindrome_Strings_Via_Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will test if a string is a palindrome by using recursion.");
            Console.WriteLine();
            Console.Write("Input a string: ");
            string inputString = Console.ReadLine();
            bool isAPalindrome = IsAPalindrome(inputString);
            Console.WriteLine();
            if (isAPalindrome)
                Console.WriteLine("The string is a palindrome! Congratulations!!");
            else 
                Console.WriteLine("The string is NOT a palindrome. Bummer");


        }

        static bool IsAPalindrome(string inputString)
        {
            int inputLength = inputString.Length;
            if (inputLength <= 1)
                return true;
            else
            {
                if (inputString[0] != inputString[inputString.Length - 1])
                    return false;
                else
                {
                    return IsAPalindrome(inputString.Substring(1, inputString.Length - 2));
                }
            }
        }
    }
}
