/**
 * https://leetcode.com/problems/excel-sheet-column-number/
 * 
 * Tags: Math
 */


using System;

namespace LeetCode.Algorithm.Easy
{
    public class ExcelSheetColumnNumber
    {
        public int TitleToNumber(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            int number = 0;

            for (int i = 0; i < s.Length; i++)
            {
                number = number * 26 + (s[i] - '@');
            }
            return number;
        }
    }
}
