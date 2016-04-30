/**
 * https://leetcode.com/problems/remove-duplicates-from-sorted-array/
 * Given a sorted array, remove the duplicates in place such 
 * that each element appear only once and return the new length.
 * 
 * Do not allocate extra space for another array, you must do this in place
 * with constant memory.
 * 
 * For example,
 * Given input array A = [1,1,2],
 * Your function should return length = 2, and A is now [1,2].
 * 
 * Tags: Array, Two pointers
 */

namespace LeetCode.Algorithm.Easy
{
    public class RemoveDuplicate
    {
        public int RemoveDuplicateStandard(int[] items)
        {
            int count = 0;
            int length = items.Length;
            for (int i = 0; i < length; i++)
            {
                if (count == 0 || items[i] != items[count - 1])
                {
                    items[count++] = items[i]; 
                }
            }
            return count;
        }

        /// <summary>
        ///     Use two pointers, one in the front, one for the dups
        /// </summary>
        public int RemoveDuplicateAdvantage(int[] items)
        {
            int i = 0;
            int j = 0;
            int position = i + 1; 
            while (i < items.Length)
            {
                j = i + 1;
                while (j < items.Length && items[i] == items[j])
                {
                    j++;
                }
                if (j >= items.Length) break; // out of range
                items[position] = items[j];
                position++;
                i = j;
            }
            return position;
        }
    }
}
