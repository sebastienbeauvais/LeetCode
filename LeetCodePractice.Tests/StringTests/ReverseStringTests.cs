using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodePractice.Functions;
using System.Diagnostics.CodeAnalysis;

namespace Company.TestProject1;

[TestClass]
public class ReverseStringTests
{
    [TestMethod]
    public void ReverseString_ShouldPrintReversedStringToConsole_WhenValidCharSetGiven()
    {
        char[] charsToReverse = new char[] {'h', 'e', 'l', 'l', 'o', ',', 'w', 'o', 'r', 'l', 'd'};
        var reverseString = new StringQuestions();

        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        var expected = "dlrow,olleh";
        var result = stringWriter.ToString();
        reverseString.ReverseString(charsToReverse);
        Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void ReverseString_ShouldPrintEmptyChar_WhenCharSetIsEmpty()
    {
        char[] charsToReverse = new char[] {};
        var reverseString = new StringQuestions();

        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        reverseString.ReverseString(charsToReverse);
        var expected = "";
        var result = stringWriter.ToString();
        Assert.AreEqual(expected, result);
    }
}
