using System;
using System.Collections.Generic;
/*Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Note that an empty string is also considered valid.

Example 1:

Input: "()"
Output: true
Example 2:

Input: "()[]{}"
Output: true
Example 3:

Input: "(]"
Output: false
Example 4:

Input: "([)]"
Output: false
Example 5:

Input: "{[]}"
Output: true*/
namespace Parentheses1
{
    class Program
    {
        public static bool IsValid(string s)
        {
            Stack<char> stack1 = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                char val = s[i];
                if (val == '(' || val == '{' || val == '[')
                    stack1.Push(val);
                else if (val == ')' || val == '}' || val == ']')
                {
                    if (stack1.Count > 0)
                    {
                        char val1 = stack1.Peek();
                        if ((val1 == '(' && val == ')') || (val1 == '{' && val == '}') || (val1 == '[' && val == ']'))
                            stack1.Pop();
                        else
                            return false;
                    }
                    else
                        return false;
                }

            }
            if (stack1.Count == 0)
                return true;
            else
                return false;
        }

        public static void Main(string[] args)
        {
            string ss = "(]";
            if (IsValid(ss))
                Console.WriteLine("true");
        }
    }
}
