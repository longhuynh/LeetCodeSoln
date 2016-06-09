/**
 * https://leetcode.com/problems/reverse-words-in-a-string/
 * 
 * Tags: String
 */

using System;
using System.Text;
using System.Text.RegularExpressions;

namespace LeetCode.Algorithm.Medium
{
    public class ReverseWord
    {
        public string ReverseWords(string sentence)
        {
            sentence = sentence.Trim();
            var left = sentence.Length - 1;
            var right = sentence.Length - 1;
            var stringBuilder = new StringBuilder();
            while (right >= 0)
            {
                if (sentence[right] == ' ')
                {
                    stringBuilder.Append(sentence.Substring(right + 1, left - right));
                    stringBuilder.Append(" ");
                    while (sentence[right] == ' ')
                    {
                        right--;
                    }
                    left = right;
                }
                else
                {
                    right--;
                }
            }
            stringBuilder.Append(sentence.Substring(right + 1, left - right));
            return stringBuilder.ToString();
        }
    }
}