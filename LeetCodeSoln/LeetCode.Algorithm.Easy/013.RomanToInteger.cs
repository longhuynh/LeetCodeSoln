/**
 * https://leetcode.com/problems/roman-to-integer/
 * 
 * Tags: Brainteaser
 */

namespace LeetCode.Algorithm.Easy
{
    public class RomanToInteger
    {
        public static int RomanToInt(string s)
        {
            int toInt = 0;
            if (string.IsNullOrEmpty(s)) return toInt;

            char[] charArray = s.ToCharArray();

            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                switch (charArray[i])
                {
                    case 'M':
                        toInt += 1000;
                        break;
                    case 'D':
                        toInt += 500;
                        break;
                    case 'C':
                        toInt += 100*(toInt >= 500 ? -1 : 1); 
                        break;
                    case 'L':
                        toInt += 50;
                        break;
                    case 'X':
                        toInt += 10*(toInt >= 50 ? -1 : 1); 
                        break;
                    case 'V':
                        toInt += 5;
                        break;
                    case 'I':
                        toInt += (toInt >= 5 ? -1 : 1); 
                        break;
                }
            }
            return toInt;
        }
    }
}
