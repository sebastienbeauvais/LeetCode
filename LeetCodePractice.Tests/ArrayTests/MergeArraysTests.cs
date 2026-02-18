using  Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodePractice.Functions;
namespace LeetCodePractice.Tests.ArrayTests;

[TestClass]
public class MergeArraysTest
{
  private ArrayQuestions _arrayQuestions = new ArrayQuestions();
  [TestMethod]
  public void Merge_ReturnedSortedArray_WhenArray1LargerThanArray2()
  {
    int[] nums1 = { 1, 2, 3, 0, 0, 0 };
    int[] nums2 = { 2, 5, 6 };
    int m = 3;
    int n = 3;
    
    _arrayQuestions.Merge(nums1, m, nums2, n);
    
    var expected = new int[]{ 1, 2, 2, 3, 5, 6 };
    Assert.AreEqual(expected, nums1);
  }

  [TestMethod]
  public void Merge_ReturnsArray1_WhenArray2IsEmpty()
  {
    int[] nums1 = {1};
    int[] nums2 = { };
    int m = 1;
    int n = 0;
    
    _arrayQuestions.Merge(nums1, m, nums2, n);

    var expected = new int[] { 1 };
    Assert.AreEqual(expected, nums1);
  }

  [TestMethod]
  public void Merge_ReturnsArray2InsideArray1_WhenArray1HoldsOnlyZero()
  {
    int[] nums1 = { };
    int[] nums2 = { 1 };
    int m = 1;
    int n = 0;
    
    _arrayQuestions.Merge(nums1, m, nums2, n);
    
    var expected = new int[] { 1 };
    Assert.AreEqual(expected, nums2);
  }
}