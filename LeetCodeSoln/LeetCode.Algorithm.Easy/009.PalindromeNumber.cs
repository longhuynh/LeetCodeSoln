/**
 * https://leetcode.com/problems/palindrome-number/
 * 
 * Tags: Math
 */

using System.Text;

namespace LeetCode.Algorithm.Easy
{
    class PalindromeNumber
    {
        /// <summary>
        /// A palindromic number or numeral palindrome is a number 
        /// that remains the same when its digits are reversed. 
        /// Like 16461, for example, it is "symmetrical".
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool IsPalindrome(int number)
        {
            if (number < 0)
                return false;

            int division = 1;

            while (number / division >= 10)
            {
                division *= 10; // two digits
            }

            while (number != 0)
            {
                // Stop till num is 0, all digits compared
                int leftDigit = number / division;
                int rightDigit = number % 10;
                if (leftDigit != rightDigit) return false;
                number = (number % division) / 10; // remove first and last digit
                division /= 100; // division should be smaller
            }
            return true;
        }
    }
}
