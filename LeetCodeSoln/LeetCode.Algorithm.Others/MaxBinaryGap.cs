//
// For example, 9's binary form is 1001, the gap is 2.
//

namespace LeetCode.Algorithm.Others
{
    public class MaxBinaryGap
    {
        public static int GetGap(int number)
        {
            var max = 0;
            var count = -1;

            while (number > 0)
            {
                // Get right most bit & shift right
                var r = number & 1;
                number = number >> 1;

                if (0 == r && count >= 0)
                {
                    count++;
                }

                if (1 == r)
                {
                    max = count > max ? count : max;
                    count = 0;
                }
            }

            return max;
        }
    }
}