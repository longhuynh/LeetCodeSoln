using System;

namespace LeetCode.Algorithm.Easy.Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(11 >> 1);
            Console.ReadKey();
        }

        public static int SingleNumber(int[] items)
        {
            var x = 0;
            foreach (var i in items)
            {
                x = x ^ i;
                Console.WriteLine(x);
            }
            return x;
        }
    }
}