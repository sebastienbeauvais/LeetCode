using System;
using System.Collections.Generic;
using System.Text;
using LeetCodePractice.Classes;

namespace LeetCodePractice.Problems
{
    public class TreeQuestions
    {
        public int MaxDepth(TreeNode root)
        {
            /*
             * Given the root of a binary tree, return its maximum depth.
             * A binary tree's maximum depth is the number of nodes along the 
             * longest path from the root node down to the farthest leaf node.
             * 
             * EX1: root = [3,9,20,null,null,15,7]
             *       3
             *      / \
             *     9   20
             *        /  \
             *       15   7
             * Output: 3 (3->20->7)
             */

            if(root == null)
            {
                return 0;
            }
            else
            {
                var left = MaxDepth(root.left);
                var right = MaxDepth(root.right);
                var maxDepth = Math.Max(left, right);
                return maxDepth + 1;
            }
        }
    }
}
