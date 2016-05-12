/**
 * https://leetcode.com/problems/excel-sheet-column-number/
 * 
 * Tags: Math
 */


using System.Text;

namespace LeetCode.Algorithm.Easy
{
    public class ExcelSheetColumnTitle
    {
        public string ConvertToTitle(int n)
        {
            if (n <= 0) return "";
            var title = new StringBuilder();
            while (n > 0)
            {
                n--; // note the 1 offset
                var r = n%26;
                title.Insert(0, (char) ('A' + r));
                n = n/26;
            }
            return title.ToString();
        }

        public static string ConvertToTitleRecursive(int n)
        {
            return n <= 0 ? "" : ConvertToTitleRecursive(--n/26) + (char) ('A' + n%26);
        }
    }
}