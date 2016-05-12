/**
 * https://leetcode.com/problems/count-and-say/
 * 
 * Tags: String
 */


using System.Text;

namespace LeetCode.Algorithm.Easy
{
    public class CountNSay
    {
        // Bottom-up approach
        public static string CountAndSay(int n)
        {
            if (n <= 0) return "";
            if (n == 1) return "1";
            var i = 2;
            var result = "1";
            while (i <= n)
            {
                var currentResult = "";
                var count = 1;
                var previousNumber = result[0];
                for (var j = 1; j < result.Length; j++)
                {
                    var currentNumber = result[j];
                    if (previousNumber == currentNumber)
                    {
                        count++;
                    }
                    else
                    {
                        currentResult += count; // update current result
                        currentResult += previousNumber;
                        count = 1; // reset count
                    }
                    previousNumber = currentNumber;
                }
                currentResult += count; // update last loop
                currentResult += previousNumber;
                result = currentResult; // build next count
                i++;
            }
            return result;
        }
    }
}