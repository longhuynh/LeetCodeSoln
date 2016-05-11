/**
 * https://leetcode.com/problems/factorial-trailing-zeroes/
 * 
 * Tags: Math
 */


using System;

namespace LeetCode.Algorithm.Easy
{
    public class FactorialTrailingZeroes
    {
        // O(log5-n)
        public static int TrailingZeroes(int n)
        {
            int trailingZeroes = 0;
            while (n > 0)
            {
                n /= 5;
                trailingZeroes += n; // add # of 5 in n
            }
            return trailingZeroes;
        }

        // Recursive
        public static int TrailingZeroesB(int n)
        {
            return n <= 0 ? 0 : n / 5 + TrailingZeroes(n / 5);
        }
    }
}
