/**
 * https://leetcode.com/problems/merge-sorted-array/
 * Given two sorted integer arrays A and B, merge B into A as one sorted array.
 * 
 * Note:
 * You may assume that A has enough space (size that is greater or equal to m +
 * n) to hold additional elements from B. The number of elements initialized in
 * A and B are m and n respectively.
 * 
 * Tags: Array
 */

namespace LeetCode.Algorithm.Easy
{
    class MergeSortedArray
    {
        public void Merge(int[] array1, int m, int[] array2, int n)
        {
            if (n == 0) return;
            while (m > 0 && n > 0)
            {
                if (array1[m - 1] > array2[n - 1])
                {
                    array1[m + n - 1] = array1[m - 1];
                    m--;
                }
                else
                {
                    array1[m + n - 1] = array2[n - 1];
                    n--;
                }
            }

            while (n > 0) array1[n - 1] = array2[n-- - 1];
        }
    }
}
