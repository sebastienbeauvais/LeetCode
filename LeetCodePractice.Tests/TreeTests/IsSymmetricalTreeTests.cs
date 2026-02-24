using System;
using System.Collections.Generic;
using System.Text;
using LeetCodePractice.Problems;
using LeetCodePractice.Classes;

namespace LeetCodePractice.Tests.TreeTests
{
    [TestClass]
    public class IsSymmetricalTreeTests
    {
        private readonly TreeQuestions _treeQuestions = new TreeQuestions();
        [TestMethod]
        public void IsSymmetricalTree_ShouldReturnTrue_WhenTreeIsSymmetrical() 
        {
            var root = new TreeNode(1, new TreeNode(2, new TreeNode(3), new TreeNode(4)), new TreeNode(2, new TreeNode(4), new TreeNode(3)));
            var result = _treeQuestions.IsSymmetrical(root);

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsSymmetricalTree_ShouldReturnFalse_WhenTreeIsNotSymmetrical()
        {
            var root = new TreeNode(1, new TreeNode(2, new TreeNode(3), new TreeNode(4)), new TreeNode(2, new TreeNode(3), new TreeNode(4)));
            var result = _treeQuestions.IsSymmetrical(root);

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void IsSymmetricalTree_ShouldReturnFalse_WhenTreeHasNullValues()
        {
            var root = new TreeNode(1, new TreeNode(2, null, new TreeNode(3)), new TreeNode(2, null, new TreeNode(3)));
            var result = _treeQuestions.IsSymmetrical(root);

            Assert.IsFalse(result);
        }
    }
}
