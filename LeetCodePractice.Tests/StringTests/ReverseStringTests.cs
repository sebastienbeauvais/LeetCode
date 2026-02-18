using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodePractice.Functions;
using System.Threading.Tasks.Dataflow;

namespace LeetcodePracitce.Tests.StringTests;

[TestClass]
public class ReverseStringTests
{
    [TestMethod]
    public void ReverseString_ShouldPrintReversedStringToConsole_WhenValidCharSetGiven()
    {
        char[] charsToReverse = new char[] {'h', 'e', 'l', 'l', 'o', ',', 'w', 'o', 'r', 'l', 'd'};
        var reverseString = new StringQuestions();

        var expected = "dlrowolleh";
        reverseString.ReverseString(charsToReverse);
        var result = string.Join(",", charsToReverse).Replace(",", "").ToString();
        Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void ReverseString_ShouldPrintEmptyChar_WhenCharSetIsEmpty()
    {
        char[] charsToReverse = new char[] {};
        var reverseString = new StringQuestions();

        reverseString.ReverseString(charsToReverse);
        var expected = "";
        var result = string.Join(",", charsToReverse).Replace(",", "").ToString();;
        Assert.AreEqual(expected, result);
    }
}
