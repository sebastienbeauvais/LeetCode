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

            throw new NotImplementedException();
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

            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
        public TreeNode SortedArrayToBST(int[] nums) 
        {

            /*
             * Given an integer array nums where the elements are sorter in ascending order. Convert it to a 
             * height-balanced binary search tree
             * 
             * Where heigt-balanced means that the depth og the substrees only differ by 1 more level
             * 
             * EX: 
             * Input: [-10,-3,0,5,9]
             * Output: [0,-3,9,-10,null,5]
             * 
             *              0
             *             / \
             *           -3   9
             *           /   /
             *        -10   5
             * 
             */

            throw new NotImplementedException();
        }
    }
}
