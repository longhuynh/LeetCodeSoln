/**
 * https://leetcode.com/problems/reverse-integer/
 * Write a function that takes a string as input and returns the string reversed.
 * 
 * Tags: Math
 */

namespace LeetCode.Algorithm.Easy
{
    class ReverseInteger
    {
        public int Reverse(int x)
        {
            long result = 0; // result might overflow
            while (x != 0)
            {
                result = result*10 + x%10; // append last digit of x
                x /= 10; // remove last digit
            }
            if (result > int.MaxValue || result < int.MinValue) return 0;
            return (int) result;
        }
    }
}
