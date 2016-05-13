/**
 * https://leetcode.com/problems/longest-substring-without-repeating-characters/
 * 
 * Tags: String
 **/

using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode.Algorithm.Easy
{
    public class LongestSubstring
    {
        // Traverse the string
        // Get current character
        //  Update start point
        //  Update max
        //  Put current char in map
        public static int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            var hashtable = new Hashtable();
            var start = 0;
            var max = 0;

            for (var i = 0; i < s.Length; i++)
            {
                var key = s[i];
                // Start point can be recent dup's next char or last start
                start = Math.Max(start, hashtable.ContainsKey(key) ? (int) hashtable[key] + 1 : 0);
                // if current str len is bigger then update
                max = Math.Max(max, i - start + 1);
                // add char to map with index
                hashtable.Remove(key);
                hashtable.Add(key, i);
            }
            return max;
        }
    }
}