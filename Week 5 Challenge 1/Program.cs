using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace Week_5_Challenge_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given an array of integers, every element appears twice except for one. Find the lonely number!\nYAY CODING! WOOT WOOT!");
            Console.WriteLine();
        // The array under test.
            int[] firstInputArray = { 2, 2, 1 };

        // Calls the NumbersFrequencies method containing the firstInputArray array.                                                                                       
        // frequencies is the name assigned to the Dictionary. It will contain the frequencies of each element in the array.
        // The method, NumberFrequencies is called.
            Dictionary<int, int> frequencies = NumberFrequencies(firstInputArray);
            
        // NumberFrequencies returns here as "frequencies"
        // Prints on screen the number of unique elements. It will display 2 because there are two numbers: 2 and 1.
            Console.WriteLine($"The number of unique elements is/are: {frequencies.Count}");

        // Creates a for each loop that checks the pairs in the frequencies dictionary.The number that appears only once will be printed.
        // foreach (var in pair in frequencies) starts the loop.
            foreach (var pair in frequencies)
            {
        // Checks to see if the frequencies of a key-value pair is exactly 1
                if (pair.Value == 1)
                {
        // If the value is exactly 1, then the code will print what the value of the element is and break the loop.
                    Console.WriteLine($"The lone number is: {pair.Key}");
                    break;
                }
            }

        }
        // This is the NumberFrequencies method that has an input of the firstInputArray and an output/return of a dictionary with an integer key and an integer value.
        // This method gets called/activated on line 18: Dictionary<int, int> frequencies = NumberFrequencies(firstInputArray);
        // Dictionary<int, int> is the return. 
        public static Dictionary<int, int> NumberFrequencies(int[] firstInputArray)
        {
        /* Creates a new dictionary named FirstArrayFrequency_Dictionary
         * FirstArrayFrequency_Dictionary will contain the <key, value> pairs of each element
         * The dictionary is the named output of the method, NumberFrequencies.
         * In the main method, FirstArrayFrequency_Dictionary is called "frequencies"====>Line 18
         */
            Dictionary<int, int> FirstArrayFrequency_Dictionary = new Dictionary<int, int>();

        // Foreach loop iterates over each element in the input array
        // number represents the element in the array
            foreach (int number in firstInputArray)
            {
        // If the number (numerical value of the element) is already in the dictionary, the number frequencies will increase by 1.
                if (FirstArrayFrequency_Dictionary.ContainsKey(number))
                {
                    FirstArrayFrequency_Dictionary[number]++;
                }
                else
                {
        // If the number has not been recorded in the dictionary, it will be assigned a frequency of 1
                    FirstArrayFrequency_Dictionary[number] = 1;
                }
            }

        // This returns the FirstArrayFrequency_Dictionary and the frequency of unique elements.
        // Returns to the main method under the name "frequencies".
            return FirstArrayFrequency_Dictionary;
        }

    }

}



