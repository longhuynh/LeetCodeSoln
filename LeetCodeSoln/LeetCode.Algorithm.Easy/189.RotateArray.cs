/**
 * https://leetcode.com/problems/rotate-array/
 * Write a function that takes a string as input and returns the string reversed.
 * 
 * Tags: String
 */


using System;

namespace LeetCode.Algorithm.Easy
{
    public class RotateArray
    {
        // O(n) Time, O(1) Space
        // Build a full circle of rotation
        // Start from current index and repeat exactly "length of array" times
        // 1. Calculate new index which is current index move k steps forward
        // If move out of range, just start from beginning again
        //      newIdx = (curIdx + k ) % len
        // 2. Circle can be the same, for example, n = 6, k = 2
        // Index will be 0, 2, 4, 0, 2, 4
        // So save the start index of the circle
        // If start from there again, move one step forward
     
        public void Rotate(int[] items, int k)
        {
            if (items == null || items.Length == 0) return;
            if (items.Length == 1 || k == 0 || k == items.Length) return; // special cases

            int length = items.Length;
            k %= length;
            int idx = 0;
            int tmp1 = items[idx]; // the number to write to new index
            for (int i = 0, j = 0; i < length; i++)
            { // j is the start index of current circle
                idx = (idx + k) % length;
                var tmp2 = items[idx]; // save the number at new index
                items[idx] = tmp1;
                tmp1 = tmp2;
                if (idx == j)
                { // circle ends
                    idx = ++j; // move to next circle
                    tmp1 = items[idx];
                }
            }
        }
    }
}
