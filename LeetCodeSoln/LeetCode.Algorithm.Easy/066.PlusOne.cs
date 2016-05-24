/**
 * https://leetcode.com/problems/plus-one/
 * 
 * Tags: Array, Math
 */

namespace LeetCode.Algorithm.Easy
{
    public class PlusOneSoln
    {
        public int[] PlusOneOthers(int[] digits)
        {
            for (var i = digits.Length - 1; i >= 0; i--)
            {
                digits[i] = 1 + digits[i];
                if (digits[i] == 10)
                {
                    digits[i] = 0;
                }
                else return digits; // no carry for current digit
            }

            var ans = new int[digits.Length + 1];
            ans[0] = 1;
            for (var i = 0; i < digits.Length; i++) ans[i + 1] = digits[i];
            return ans;
        }

        public int[] PlusOne(int[] digits)
        {
            var count = digits.Length;
            while (count > 0)
            {
                digits[count - 1] = digits[count - 1] + 1;
                if (digits[count - 1] > 9)
                {
                    digits[count - 1] = 0;
                }
                else
                {
                    return digits;
                }
                count--;
            }
            var result = new int[digits.Length + 1];
            result[0] = 1;
            for (var i = 1; i < digits.Length; i++)
            {
                result[i] = digits[i - 1];
            }

            return result;
        }
    }
}
