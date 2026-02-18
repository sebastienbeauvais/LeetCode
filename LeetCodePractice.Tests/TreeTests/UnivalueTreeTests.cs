using LeetCodePractice.Classes;
using LeetCodePractice.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodePractice.Tests.TreeTests
{
    [TestClass]
    public class UnivalueTreeTests
    {
        private readonly TreeQuestions _treeQuestions = new TreeQuestions();
        [TestMethod]
        public void IsUnivalTree_ShouldReturnTrue_WhenAllNodesSameValueAsRoot()
        {
            var tree = new TreeNode(1, new TreeNode(1), new TreeNode(1, new TreeNode(1, new TreeNode(1))));

            var result = _treeQuestions.IsUnivalTree(tree);

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsUnivalTree_ShouldReturnFalse_WhenRootIsDifferentValueThanChild()
        {
            var tree = new TreeNode(1, new TreeNode(2));

            var result = _treeQuestions.IsUnivalTree(tree);

            Assert.IsFalse(result);
        }
    }
}
