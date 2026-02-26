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

            var expected = new TreeNode(0, new TreeNode(-3, new TreeNode(-10)), new TreeNode(5, null, new TreeNode(9)));

            Assert.AreEqual(expected, result);
        }
    }
}
