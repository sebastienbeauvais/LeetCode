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

            if(p == null && q == null)
            {
                return true;
            }
            else if((p == null && q != null) || (q == null && p != null))
            {
                return false;
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
        public bool IsSymmetrical(TreeNode root) 
        {
            /*
             * Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).
             * 
             * EX:       1
             *          / \
             *         2   2
             *        / \  /\
             *       3   4 4 3
             * Output: True
             */
            throw new NotImplementedException();
        }
        public IList<int> InOrderTraversal(TreeNode root)
        {
            /*
             * Given the root of a binary tree, return the inorder traversal of its nodes values
             * 
             * EX:
             *         1
             *          \
             *           2
             *          /
             *         3
             * Output: [1,3,2] because InOrder is Left, root, Right
             * 
             */

            // We should use a helper function so that we can return the int when it is found.
            // Else we consistently overwrite the output list which results in us only returning a list with 
            // the last value visited
            IList<int> output = new List<int>();

            if(root == null)
            {
                return [];
            }
            if (root != null && root.val != 0) 
            {
                GetNodeValue(root, output);
            }
            
            
            return output;

        }
        private void GetNodeValue(TreeNode root, IList<int> foundNodes) 
        {
            if(root != null)
            {
                
                GetNodeValue(root.left, foundNodes);
                // We need to add the root;
                foundNodes.Add(root.val);
                GetNodeValue(root.right, foundNodes);
            } 
        }
    }
}