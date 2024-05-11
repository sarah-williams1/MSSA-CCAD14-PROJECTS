using System.ComponentModel.DataAnnotations;

namespace Assignment_1._3._2
/*ASSIGNMENT 1.3.2: Create and array, then reverse the array.
 * Index 0 : Value 2
 * Index 1 : Value 5
 * Index 2 : Value 7
 * "Length" is the number of elements (n) in an array.
 * Index of last element is n-1, because the first element has an index of 0
 * To reverse the array, create a loop that will repeate Length/2 times
 */
{
    internal class program
    {
        static void Main()
        {
            int[] integerArray = { 2, 5, 7 };
            int temp;

            Console.WriteLine("The values stored in the array are:");
            for (int q = 0; q < integerArray.Length; q++)
            {
                Console.WriteLine(integerArray[q]);
            }
            Console.WriteLine("The values of the array in reverse are: ");
            for (int q = 0; q < integerArray.Length / 2; q++)
            {
                // Stores value of the element to the variable 'temp'
                temp = integerArray[q];
                // Swaps the first and last elements
                integerArray[q] = integerArray[integerArray.Length - q - 1];
                // Gives the swapped element value to 'temp'
                // If the below line was 'temp = integerArray[integerArray.Length -q -1]', then the printed result would be 7 5 7.
                integerArray[integerArray.Length - q - 1] = temp;
            }
            // Prints the value of q in the array in reverse order. 
            // q has already been reversed from the above code

            foreach(int q in integerArray)
            {
                Console.WriteLine(q);
            }
        }
    }
}