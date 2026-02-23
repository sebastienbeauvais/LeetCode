using LeetCodePractice.Classes;
using LeetCodePractice.Functions;
using LeetCodePractice.Problems;

namespace LeetCodePractice.Tests.TreeTests
{
    [TestClass]
    public class IsSameTreeTests
    {
        private TreeQuestions _treeQuestions = new TreeQuestions();
        [TestMethod]
        public void IsSameTree_ShouldReturnTrue_WhenTreesAreTheSame()
        {
            var tree1 = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            var tree2 = new TreeNode(1, new TreeNode(2), new TreeNode(3));

            var result = _treeQuestions.IsSameTree(tree1, tree2);
            
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsSameTree_ShouldReturnFalse_WhenTreesAreMirrorsOfEachother()
        {
            var tree1 = new TreeNode(1, new TreeNode(3), new TreeNode(2));
            var tree2 = new TreeNode(1, new TreeNode(2), new TreeNode(3));

            var result = _treeQuestions.IsSameTree(tree1, tree2);

            Assert.IsFalse(result);
        }
        [TestMethod]
        public void IsSameTree_ShouldReturnFalse_WhenTreesDiffer()
        {
            var tree1 = new TreeNode(1, new TreeNode(6), new TreeNode(9));
            var tree2 = new TreeNode(1, new TreeNode(2));

            var result = _treeQuestions.IsSameTree(tree1, tree2);

            Assert.IsFalse(result);
        }
    }
}
