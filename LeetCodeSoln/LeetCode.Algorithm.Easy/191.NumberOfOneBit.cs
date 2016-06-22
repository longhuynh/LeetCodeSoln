/**
 * https://leetcode.com/problems/number-of-1-bits/
 * 
 * Tags: Bit Manipulation

 */


using System;

namespace LeetCode.Algorithm.Easy
{
    public class NumberOfOneBit
    {
        public int HammingWeight(uint number)
        {
            var count =0;

            while (number > 0)
            {
                var r = number & 1;
                number = number >> 1;

                if (1 == r)
                {
                    count ++;
                }
            }

            return count;
        }
    }
}
