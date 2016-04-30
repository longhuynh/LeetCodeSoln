/**
 * https://leetcode.com/problems/reverse-string/
 * Write a function that takes a string as input and returns the string reversed.
 * 
 * Tags: String
 */


using System;

namespace LeetCode.Algorithm.Easy
{
    class ReverseString
    {
        public string ReverseAString(string s)
        {
            //char[] charArray = s.ToCharArray();
            //int length = s.Length;
            //int halfLength = length / 2;

            //for(int i = 0; i < halfLength; i++ )
            //{
            //    char temp = charArray[i];
            //    charArray[i] = charArray[length - 1 - i];
            //    charArray[length - 1 - i] = temp;
            //}
            // new string(charArray);
            // if (s.Length == 0) 
            //     return s;

            //return ReverseString(s.Substring(1)) + s[0];

            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
