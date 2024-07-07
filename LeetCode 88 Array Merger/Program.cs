/*
  You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements 
  in nums1 and nums2 respectively.

  Merge nums1 and nums2 into a single array sorted in non-decreasing order.

The final sorted array should not be returned by the function, but instead be stored inside the array nums1.
To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, 
and the last n elements are set to 0 and should be ignored. nums2 has a length of n.

 

Example 1:

Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
Output: [1,2,2,3,5,6]
Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.
*/


using System.ComponentModel.Design;

namespace LeetCode_88_Array_Merger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = { 2, 5, 6 };
            int m = 3; // Only includes the non-zero elements
            int n = nums2.Length;
            int point1 = m - 1; // last element spot in nums1 array
            int point2 = n - 1; // last element spot in nums2 array
            int last = m + n - 1;

            while (point1 > 0 && point2 > 0)
            {
                if (nums1[point1] > nums2[point2])
                {
                    nums1[last] = nums1[point1];
                    point1--;
                }
                else
                {
                    nums1[last] = nums2[point2];
                    point2--;
                }
                last--;
            }

            foreach (int i in nums1)
            {
                Console.WriteLine(i + " ");
            }
            
        }

    }
}
