/**
 * https://leetcode.com/problems/reverse-words-in-a-string/
 * 
 * Tags: String
 */

using System;

namespace LeetCode.Algorithm.Medium
{
    public class KthLargestElementReverseWord
    {
        public int FindKthLargest(int[] nums, int k)
        {
            Array.Sort(nums);
            return nums[nums.Length - k];
        }

        public int FindKthLargestQickSort(int[] nums, int k)
        {
            if (k > nums.Length)
            {
                return -1;
            }

            QuickSort(nums, 0, nums.Length - 1);

            return nums[k - 1];
        }


        public void QuickSort(int[] nums, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            var povit = nums[end];

            int i = start, j = start;

            for (; j < end; j++)
            {
                if (nums[j] > povit)
                {
                    var temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    i += 1;
                }
            }

            nums[end] = nums[i];
            nums[i] = povit;

            QuickSort(nums, start, i - 1);
            QuickSort(nums, i + 1, end);
        }


        // Quick sort improvement with k

        public int QuickSortK(int[] nums, int start, int end, int k)
        {
            var povit = nums[end];

            if (start >= end)
            {
                return povit;
            }

            int i = start, j = start;

            for (; j < end; j++)
            {
                if (nums[j] > povit)
                {
                    var temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    i += 1;
                }
            }

            nums[end] = nums[i];
            nums[i] = povit;

            if (i == k - 1)
            {
                return povit;
            }
            if (i > k - 1)
            {
                return QuickSortK(nums, start, i - 1, k);
            }
            return QuickSortK(nums, i + 1, end, k);
        }
    }
}