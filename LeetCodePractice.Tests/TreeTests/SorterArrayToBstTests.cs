using System;
using System.Collections.Generic;
using System.Text;
using LeetCodePractice.Classes;
using LeetCodePractice.Functions;
using LeetCodePractice.Problems;

namespace LeetCodePractice.Tests.TreeTests
{
    [TestClass]
    public class SorterArrayToBstTests
    {
        private readonly TreeQuestions _treeQuestions = new TreeQuestions();

        [TestMethod]
        public void SorterArrayToBst_ShouldReturnBst_WhenValidArrayGiven()
        {
            int[] nums = { -10, -3, 0, 5, 9 };

            var result = _treeQuestions.SortedArrayToBST(nums);

            var inorderResult = InOrderTraversal(result);

            CollectionAssert.AreEqual(nums, inorderResult);
        }
        private List<int> InOrderTraversal(TreeNode root)
        {
            var result = new List<int>();
            Traverse(root, result);
            return result;

        }
        private void Traverse(TreeNode root, List<int> values)
        {
            if (root == null) return;

            Traverse(root.left, values);
            values.Add(root.val);
            Traverse(root.right, values);
        }
    }
}
