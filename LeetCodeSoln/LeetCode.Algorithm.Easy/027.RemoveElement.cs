/**
 * https://leetcode.com/problems/remove-element/
 * 
 * Tags: Array, Two Pointer
 */

namespace LeetCode.Algorithm.Easy
{
    public class RemoveElementSoln
    {
        public int RemoveElement(int[] items, int element)
        {
            if (items == null || items.Length == 0) return 0;
            int i = 0;
            int j = items.Length;
            while (i < j)
            {
                if (items[i] == element)
                {
                    items[i] = items[j - 1]; // move last element
                    j--; // decrease Length
                }
                else i++; // move on
            }
            return j;
        }
    }
}
