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
            return IsMirror(root, root);
        }
        private bool IsMirror(TreeNode left, TreeNode right)
        {
            if(left == null && right == null)
            {
                return true;
            }
            if(left == null || right == null)
            {
                return false;
            }
            if(left.val != right.val)
            {
                return false;
            }
            return (IsMirror(left.left, right.right) && IsMirror(left.right, right.left));
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

            // We know that the array is in increasing order
            // That means is the first value in the array is less than 0 we should split the array into two sides
            //      One where the values are less than 0 (the left side of the tree
            //      One where the values are greater than 0 (the right side of the tree)
            // Otherwise if the first value is 0 or greater we can just start building the binary tree
            // This comes with a catch
            //      We need to add new nodes on the current level until it is full
            //      That measn level 1 = 1 node
            //      Level 2 = 2 nodes
            //      level 3 = 4 nodes...

            // find the arrays index for the first value that is 0 or greater
            if (nums.Length == 0)
            {
                return null;
            }
            TreeNode head = CreateTreeNode(nums, 0, nums.Length - 1);
            return head;
        }
        private TreeNode CreateTreeNode(int[] nums, int low, int high) 
        {
            if(low > high)
            {
                return null; // We are done and 
            }
            int mid = low + (high - low) / 2; // We find the middle value to split the tree
            TreeNode node = new TreeNode(nums[mid]);
            node.left = CreateTreeNode(nums, low, mid - 1);
            node.right = CreateTreeNode(nums, mid + 1, high);

            return node;
        }
    }
}