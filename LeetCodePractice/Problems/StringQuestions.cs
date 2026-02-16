using System;

namespace LeetCodePractice.Functions
{
    public class StringQuestions
    {
        public bool IsValid(string s)
        {
            /*
            Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

            An input string is valid if:

            Open brackets must be closed by the same type of brackets.
            Open brackets must be closed in the correct order.
            Every close bracket has a corresponding open bracket of the same type.

            EX 1: Input: s = "()" Output: true
            EX 2: Input s = "{]" Output: false
            */
            string leftParens = "[{(";
            string rightParens = "]})";
            if (s == string.Empty || s == null || s == "")
            {
                return false;
            }
            else
            {
                var seenParentheses = new Stack<char>();
                for(int i = 0; i < s.Length; i++)
                {
                    if(leftParens.Contains(s[i]))
                    {
                        seenParentheses.Push(s[i]);
                    }
                    else if (rightParens.Contains(s[i]) 
                        && ((seenParentheses.Peek() == '(' && s[i] == ')') 
                        || (seenParentheses.Peek() == '{' && s[i] == '}') 
                        || (seenParentheses.Peek() == '[' && s[i] == ']')))
                    {
                        seenParentheses.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                if(seenParentheses.Count() == 0)
                {
                    return true;
                }
                return false;
            }
        }
        public void ReverseString(char[] s)
        {
            var charStack = new Stack<char>();
            for(int i = 0; i < s.Length; i++){
                charStack.Push(s[i]);
            }
            for(int i = 0; i < s.Length; i++)
            {
                s[i] = charStack.Pop();
            }
        }
    }
}
