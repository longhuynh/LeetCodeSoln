/**
 * https://leetcode.com/problems/maximum-depth-of-binary-tree/
 * https://leetcode.com/problems/minimum-depth-of-binary-tree/
 * 
 * Tags: Tree, DFS
 */


using System;

namespace LeetCode.Algorithm.Easy
{
    public class DepthOfBinaryTree
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            var left = MaxDepth(root.Left);
            var right = MaxDepth(root.Right);
            return Math.Max(left, right) + 1;
        }

        public int MinDepth(TreeNode root)
        {
            if (root == null) return 0;
            int left = MinDepth(root.Left);
            int right = MinDepth(root.Right);
            if (left == 0) return right + 1;
            if (right == 0) return left + 1;
            return Math.Min(left, right) + 1;
        }
    }

    public class TreeNode
    {
        public int Value;
        public TreeNode Left;
        public TreeNode Right;
    }
}
