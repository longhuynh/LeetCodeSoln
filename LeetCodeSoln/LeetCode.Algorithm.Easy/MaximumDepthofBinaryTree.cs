/**
 * https://leetcode.com/problems/maximum-depth-of-binary-tree/
 * 
 * Tags: Tree, DFS
 */


using System;

namespace LeetCode.Algorithm.Easy
{
    public class MaximumDepthOfBinaryTree
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            var left = MaxDepth(root.Left);
            var right = MaxDepth(root.Right);
            return Math.Max(left, right) + 1;
        }
    }

    public class TreeNode
    {
        public int Value;
        public TreeNode Left;
        public TreeNode Right;
    }
}
