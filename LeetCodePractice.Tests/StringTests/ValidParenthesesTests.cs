using LeetCodePractice.Functions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Company.TestProject1;

[TestClass]
public class ValidParenthesesTests
{
    public readonly StringQuestions stringQuestions = new StringQuestions();
    [TestMethod]
    public void ValidParentheses_ShouldReturnTrue_WhenParenthesesAreValid()
    {
        var parentheses = "()";
        var result = stringQuestions.IsValid(parentheses);
        Assert.IsTrue(result);
    }
    public void ValidParentheses_ShouldReturnTrue_WithMixedParentheses()
    {
        var parentheses = "()[]{}";
        var result = stringQuestions.IsValid(parentheses);
        Assert.IsTrue(result);
    }
    public void ValidParentheses_ShouldReturnFalse_WhenParenthesesAreNotValid()
    {
        var parentheses = "(]";
        var result = stringQuestions.IsValid(parentheses);
        Assert.IsFalse(result);
    }
    public void ValidParentheses_ShouldReturnTrue_WhenParenthesesAreNested()
    {
        var parentheses = "([])";
        var result = stringQuestions.IsValid(parentheses);
        Assert.IsTrue(result);
    }
    public void ValidParentheses_ShouldReturnFalse_WhenParenthesesAreNestedAndInvalid()
    {
        var parentheses = "([})";
        var result = stringQuestions.IsValid(parentheses);
        Assert.IsFalse(result);
    }
}
