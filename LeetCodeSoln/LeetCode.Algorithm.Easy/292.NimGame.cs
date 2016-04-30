/**
 * https://leetcode.com/problems/nim-game/
 * 
 * Tags: Brainteaser
 */

using System;

namespace LeetCode.Algorithm.Easy
{
    public class NimGame
    {
        public bool ResolveNimGame(int n)
        {
            return (n & 3) != 0; // n % 4 != 0;
        }
    }
}
