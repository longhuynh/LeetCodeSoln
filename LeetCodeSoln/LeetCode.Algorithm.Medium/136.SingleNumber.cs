/**
 * https://leetcode.com/problems/single-number/
 * 
 * Tags: Bit Manipulation

 */

using System;

namespace LeetCode.Algorithm.Medium
{
    public class SingleNumber
    {
        public int FindSingleNumber(int[] items)
        {
            var x = 0;
            foreach (var i in items)
            {
                x = x ^ i;
            }
            return x;
        }
    }
}