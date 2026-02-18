using LeetCodePractice.Classes;
using LeetCodePractice.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodePractice.Tests.TreeTests
{
    [TestClass]
    public class MaxDepthOfTreeTests
    {
        private readonly TreeQuestions _treeQuestions = new TreeQuestions();
        [TestMethod]
        public void MaxDepth_ShouldReturn3_WhenTreeHasTwoChildren()
        {
            var tree = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15, new TreeNode(7))));

            var result = _treeQuestions.MaxDepth(tree);
            var expected = 3;

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void MaxDepth_ShouldReturn2_WhenTreeHasOneChild()
        {
            var tree = new TreeNode(1, new TreeNode(2));

            var result = _treeQuestions.MaxDepth(tree);
            var expected = 2;

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
         public void MaxDepth_ShouldReturn1_WhenTreeHasNoChildren()
        {
            var tree = new TreeNode(1);

            var result  = _treeQuestions.MaxDepth(tree);
            var expected = 1;
 
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
         public void MaxDepth_ShouldReturn0_WhenTreeIsEmpty()
        {
            var tree = new TreeNode();

            var result = _treeQuestions.MaxDepth(tree);
            var expected = 0;

            Assert.AreEqual(expected, result);
        }
    }
}
