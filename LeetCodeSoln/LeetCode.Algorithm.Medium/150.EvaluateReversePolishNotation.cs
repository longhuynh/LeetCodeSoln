/**
 * https://leetcode.com/problems/evaluate-reverse-polish-notation/
 * 
 * Tags: Stack
 */

using System;
using System.Collections.Generic;

namespace LeetCode.Algorithm.Medium
{
    public class EvaluateReversePolishNotation
    {
        public int EvalRPN(string[] tokens)
        {
            // The stack of integers not yet operated on
            var values = new Stack<int>();

            foreach (var token in tokens)
            {
                // if the value is an integer...
                int value;
                if (int.TryParse(token, out value))
                {
                    // ... push it to the stack
                    values.Push(value);
                }
                else
                {
                    // otherwise evaluate the expresion...
                    var right = values.Pop();
                    var left = values.Pop();

                    // ... and pop the result back to the stack
                    switch (token)
                    {
                        case "+":
                            values.Push(left + right);
                            break;
                        case "-":
                            values.Push(left - right);
                            break;
                        case "*":
                            values.Push(left*right);
                            break;
                        case "/":
                            values.Push(left/right);
                            break;
                        case "%":
                            values.Push(left%right);
                            break;
                        default:
                            throw new ArgumentException($"Unrecognized token: {token}");
                    }
                }
            }

            // the last item on the stack is the result
            return values.Pop();
        }
    }
}