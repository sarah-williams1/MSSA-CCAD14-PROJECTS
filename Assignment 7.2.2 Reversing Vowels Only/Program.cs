// Reverse the vowels only.
// Example 1: "hello" has an output of "holle"
// Example 2: "avacado" has an output of "ovacada"
// Example 3: intelligent" has an output of "entillegint" 22

using System.Globalization;

namespace Assignment_7._2._2_Reversing_Vowels_Only
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = ReverseVowels(input);
            Console.WriteLine(output);
        }
        static Boolean IsVowel(char c)
        {
            return ( c == 'a' || c == 'A' || c == 'e' ||
                     c == 'E' || c == 'i' || c == 'I' ||
                     c == 'o' || c == 'O' || c == 'u' ||
                     c == 'U' );
        }
        static string ReverseVowels(string input)
        {
            string output = " ";
            int i = 0;                // i is the pointer, starting at the first element
            int j = input.Length - 1; // j is the pointer, starting at the last element
            char[] str1 = input.ToCharArray();

            while (i < j)
            {
                if (!IsVowel(str1[i]))
                {
                    i++;
                    continue;
                    // do something
                }
                if (!IsVowel(str1[j]))
                {
                    j--;
                    continue;
                }
                char temp = str1[i];
                str1[i] = str1[j];
                str1[j] = temp;

                i++;
                j--;

            }
            String str2 = String.Join("", str1);
            return str2;
        }
    }


}
