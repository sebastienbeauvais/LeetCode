using System;
using System.Collections.Generic;
using System.Text;
using LeetCodePractice.Functions;
using LeetCodePractice.Classes;
using LeetCodePractice.Problems;

namespace LeetCodePractice.Tests.TreeTests
{
    [TestClass]
    public class InOrderTraversalTests
    {
        private readonly TreeQuestions _treeQuestions = new TreeQuestions();
        
        [TestMethod]
        public void InOrderTraversal_ShouldReturnListOfValuesInOrderVisistedFromLeftRootRight_WhenOnlyRightSideBranch()
        {
            var tree = new TreeNode(1, null, new TreeNode(2, new TreeNode(3)));
            IList<int> expected = new List<int> { 1, 3, 2};

            var result = _treeQuestions.InOrderTraversal(tree);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void InOrderTraversal_ShouldReturnListOfValuesInOrderVisited_WhenLeftAndRightSideBranchExists()
        {
            var tree = new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5, new TreeNode(6), new TreeNode(7))), new TreeNode(3, new TreeNode(8, new TreeNode(9)), null));
            IList<int> expected = new List<int> { 4, 2, 6, 5, 7, 1, 3, 9, 8 };

            var result = _treeQuestions.InOrderTraversal(tree);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void InOrderTraversal_ShouldReturnNull_WhenRootIsEmpty()
        {
            var tree = new TreeNode();

            IList<int> expected = new List<int>();

            var result = _treeQuestions.InOrderTraversal(tree);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void InOrderTraversal_ShouldReturnRoot_WhenOnlyRootPresent()
        {
            var tree = new TreeNode(1);
            IList<int> expected = new List<int> { 1 };

            var result = _treeQuestions.InOrderTraversal(tree);

            Assert.AreEqual(expected, result);
        }
    }
}
