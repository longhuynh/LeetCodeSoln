/**
 * https://leetcode.com/problems/isomorphic-strings/
 * Write a function that takes a string as input and returns the string reversed.
 * 
 * Tags: HashTable
 */


using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode.Algorithm.Easy
{
    public class IsomorphicString
    {
        public static bool IsIsomorphic(string s, string t)
        {
            if (s == null || t == null)
                return false;

            if (s.Length != t.Length)
                return false;

            var dictionary = new Dictionary<char, char>();


            for (var i = 0; i < s.Length; i++)
            {
                var c1 = s[i];
                var c2 = t[i];

                if (dictionary.ContainsKey(c1))
                {
                    if (dictionary[c1] != c2) // if not consistant with previous ones
                        return false;
                }
                else
                {
                    if (dictionary.ContainsValue(c2)) //if c2 is already being mapped
                        return false;
                    dictionary.Add(c1, c2);
                }
            }

            return true;
        }
    }
}