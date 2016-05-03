/**
 * https://leetcode.com/problems/integer-to-roman/
 * 
 * Tags: Brainteaser
 */

using System.Text;

namespace LeetCode.Algorithm.Medium
{
    public class IntegerToRoman
    {
        private readonly int[] ints = {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
        private readonly string[] romans = {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};

        public string IntToRoman(int number)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int i = 0;
            while (number > 0 && i < ints.Length)
            {
                if (number >= ints[i])
                {
                    stringBuilder.Append(romans[i]);
                    number -= ints[i]; // update number
                }
                else
                {
                    i++; // move to next roman
                }
            }
            return stringBuilder.ToString();
        }

        //public string IntToRoman(int num)
        //{
        //    for (int i = 0; i < intDict.length; i++)
        //    {
        //        if (intDict[i] <= num)
        //        {
        //            return romanDict[i] + intToRoman(num - intDict[i]);
        //        }
        //    }
        //    return ""; // Note the return statement
        //}
    }
}
