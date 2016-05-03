/**
 * https://leetcode.com/problems/zigzag-conversion/
 * 
 * Tags: String
 */

using System.Text;

namespace LeetCode.Algorithm.Easy
{
    class ZigZagConversion
    {
        public string Convert(string s, int numberOfRows)
        {
            StringBuilder[] stringBuilders = new StringBuilder[numberOfRows];
            int i = 0;

            for (; i < stringBuilders.Length; i++)
            {
                stringBuilders[i] = new StringBuilder();
            }

            i = 0;

            char[] charArray = s.ToCharArray();
            int length = charArray.Length;

            while (i < length)
            {
                for (int j = 0; j < numberOfRows && i < length; j++)
                {
                    // from 0 to numberOfRows - 1
                    stringBuilders[j].Append(charArray[i++]);
                }
                for (int j = numberOfRows - 2; j > 0 && i < length; j--)
                {
                    // numberOfRows - 2 to 1
                    stringBuilders[j].Append(charArray[i++]);
                }
            }

            for (int k = 1; k < numberOfRows; k++)
            {
                stringBuilders[0].Append(stringBuilders[k]);
            }

            return stringBuilders[0].ToString();
        }
    }
}
