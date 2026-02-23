using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodePractice.Classes;
using LeetCodePractice.Functions;

namespace LeetCodePractice.Tests.ListTests;

  [TestClass]
  public class MergeTwoListsTest
  {
  ListQuestions listQuestions = new ListQuestions();
  [TestMethod]
  public void MergeTwoLists_ReturnsExpected_WhenTwoValidListsAreProvided()
  {
    ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
    ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
    var result = listQuestions.MergeTwoLists(list1, list2);
    var expected = new int[] { 1, 1, 2, 3, 4, 4 };
    CollectionAssert.AreEqual(expected, ToArray(result));
  }
  [TestMethod]
  public void MergeTwoLists_ShouldReturnEmptyArray_WhenListsAreEmpty()
  {
    ListNode list1 = null;
    ListNode list2 = null;
    var result = listQuestions.MergeTwoLists(list1, list2);
    var expected = new int[]{};
    CollectionAssert.AreEqual(expected, ToArray(result));
  }
  [TestMethod]
  public void MergeTwoLists_ShouldReturnList2_WhenList1IsEmpty()
  {
    ListNode list1 = null;
    ListNode list2 = new ListNode(0, null);
    var result = listQuestions.MergeTwoLists(list1, list2);
    var expected = new int[] {0};
    CollectionAssert.AreEqual(expected, ToArray(result));
  }

  private static int[] ToArray(ListNode? node)
  {
    var list = new List<int>();
    while (node != null)
    {
      list.Add(node.val);
      node = node.next;
    }
    return list.ToArray();
  }
}
