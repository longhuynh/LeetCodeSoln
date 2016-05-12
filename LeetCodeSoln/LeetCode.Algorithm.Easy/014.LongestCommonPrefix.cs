/**
 * https://leetcode.com/problems/longest-common-prefix/
 * 
 * Tags: String
 **/

using System;
using System.Text;

namespace LeetCode.Algorithm.Easy
{
    public class LongestCommonPrefix
    {
        // Find common prefix one by one from the end of the input string array
        // Overwrite the ith string with common prefix result
        // Thus space usage is reduced
        // Return first in group

        public static string CountLongestCommonPrefix(string[] input)
        {
            for (var i = input.Length - 2; i >= 0; i--)
            {
                input[i] = CommonPrefix(input[i + 1], input[i]);
            }
            return input[0];
        }

        // Get length of two strings
        // Loop over each char till one length runs out
        // If same char, append it to result
        // If not same, break
        // Return result

        private static string CommonPrefix(string a, string b)
        {
            var stringBuilder = new StringBuilder();
            var lengthA = a.Length;
            var lengthB = b.Length;
            var i = 0;
            while (i < lengthA && i < lengthB)
            {
                if (a[i] == b[i]) stringBuilder.Append(a[i]);
                else break;
                i++;
            }
            return stringBuilder.ToString();
        }

        // Only need to know the length of prefix
        // Initialize result with first word
        // Traverse from second word to last word
        // Get minimum length of current result and next word
        // Check whether prefix is that long in that length
        ///
        public string LongestCommonPrefixB(string[] input)
        {
            if (input == null) return null;
            if (input.Length == 0) return "";
            if (input.Length == 1) return input[0];

            var word = input[0];
            var prefixLength = word.Length;

            for (var i = 1; i < input.Length; ++i)
            {
                var nextWord = input[i];
                prefixLength = Math.Min(prefixLength, nextWord.Length);
                for (var j = 0; j < prefixLength; ++j)
                    if (word[j] != nextWord[j])
                    {
                        prefixLength = j;
                        break;
                    }
            }

            return word.Substring(0, prefixLength);
        }
    }
}