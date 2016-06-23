/**
 * https://leetcode.com/problems/two-sum/
 * 
 * Tags: String
 **/

using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode.Algorithm.Easy
{
    public class TwoSum1    {
        public int[] TwoSum(int[] numbers, int target)
        {
            var dictionary = new Dictionary<int, int>();
            var result = new int[2];

            for (var i = 0; i < numbers.Length; i++)
            {
                if (dictionary.ContainsKey(numbers[i]))
                {
                    var index = dictionary[numbers[i]];
                    result[0] = index;
                    result[1] = i;
                    break;
                }
                if (!dictionary.ContainsKey(target - numbers[i]))
                {
                    dictionary.Add(target - numbers[i], i);
                }
            }

            return result;
        }
    }
}