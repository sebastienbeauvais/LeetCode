using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
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
            throw new NotImplementedException();
        }
        public bool IsUnivalTree(TreeNode root)
        {
            /*
             * A binary tree is uni-valued if every node in the tree has the same value.
             * Given the root of a binary tree, return true if the given tree is uni-valued, 
             * or false otherwise.
             * 
             * EX1: root = [1,1,1,1,1,null,1]
             *       1
             *      / \
             *     1   1
             *    / \   \
             *   1   1   1
             * Output: true
             */

            if(root == null)
            {
                return true; // We reached the bottom of the branch
            }
            else
            {
                if(root.left != null && root.left.val != root.val)
                {
                    return false;
                }
                if (root.right != null && root.right.val != root.val) 
                {
                    return false;
                }
                return IsUnivalTree(root.left) && IsUnivalTree(root.right);
            }
        }
        public bool IsSameTree(TreeNode p, TreeNode q) 
        {
            /*
             * Given the roots of two binary trees p and q, write a function to check if 
             * they are the same or not.Two binary trees are considered the same if they 
             * are structurally identical, and the nodes have the same value.
             * EX1: p = [1,2,3], q = [1,2,3]
             *       1          1
             *      / \        / \
             *     2   3      2   3
             * Output: true
             */

            if(p == null || q == null)
            {
                return true;
            }
            else
            {
                if (p.val == q.val)
                {
                    var isLeftBranchMatch = IsSameTree(p.left, q.left);
                    var isRightBranchMatch = IsSameTree(p.right, q.right);
                    if(isLeftBranchMatch == false || isRightBranchMatch == false)
                    {
                        return false;
                    }
                    return true;
                }
                return false;
                
            }
        }
    }
}
