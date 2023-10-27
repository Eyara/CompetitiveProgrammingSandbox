using System.Text;
using SolutionRunner.Base;

namespace SolutionRunner.Stack;

/// <summary>
/// https://leetcode.com/problems/remove-outermost-parentheses/
/// </summary>
public class RemoveOutermostParentheses: BaseSolution
{
    public string RemoveOuterParentheses(string s)
    {
        var customStack = new CustomStack();
        var sb = new StringBuilder();

        foreach (var ch in s)
        {
            customStack.Push(ch);
            sb.Append(customStack.TryToGetParentheses());
        }

        return sb.ToString();
    }

    public override void Solve()
    {
        var input = Console.ReadLine();

        if (input != null) Console.WriteLine(RemoveOuterParentheses(input));
    }
}

public class CustomStack
{
    private List<char> _stack = new List<char>();
    private int _parentDepth = 0;

    public void Push(char value)
    {
        _stack.Add(value);

        if (value == '(')
        {
            _parentDepth++;
        }
        else
        {
            _parentDepth--;
        }
    }

    public string TryToGetParentheses()
    {
        if (_parentDepth == 0)
        {
            var result = new string(_stack.ToArray());
            result = result.Substring(1, result.Length - 2);
            _stack.Clear();
            return result;
        }
        else
        {
            return string.Empty;
        }
    }
}