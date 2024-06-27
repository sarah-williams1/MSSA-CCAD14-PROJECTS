namespace Assignment_8._1_Quick_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedArray = { 10, 12, 23, 43, 34, 32, 21, 1, 11, 33, 55, 77, 110, 66 };
            Console.WriteLine("This array is not sorted: " + string.Join(", ", unsortedArray));
            QuickSortAlgorithm.QuickSort(unsortedArray, 0, unsortedArray.Length - 1);
            Console.WriteLine("The sorted array is this: " + string.Join(", ", unsortedArray));
            Console.WriteLine("I LOVE RECURSION!");
        }
    }


    public class QuickSortAlgorithm
    {
        public static void QuickSort(int[] array, int left, int right)  // This method sorts the array
        {
            if (left < right)
            {                                                                       
                int pivotIndex = Partition(array, left, right);     // Partition the array and get the pivot index
                QuickSort(array, left, pivotIndex - 1);    // Recursively call QuickSort on the left part of the array
                QuickSort(array, pivotIndex + 1, right);    // Recursively call QuickSort on the right part of the array
            }
        }

                                                                           
        private static int Partition(int[] array, int left, int right) // This method is used to partition the array around the pivotIndex
        {
                                                                       
            int pivot = array[right];  // Sets the number on the right as the pivot point
            int i = left - 1;
                                                            
            for (int j = left; j < right; j++) // Rearrange the array by putting elements smaller than the pivot on the left and larger on the right
            {
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }
                        
            Swap(array, i + 1, right);    // Place the pivot in the correct position
            return i + 1;
        }

       
        private static void Swap(int[] array, int i, int j)  // This method is used to swap two elements in the array
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }    

}
