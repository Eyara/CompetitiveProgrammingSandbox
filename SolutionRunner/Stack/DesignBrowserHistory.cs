using SolutionRunner.Base;

namespace SolutionRunner.Stack;

/// <summary>
///     https://leetcode.com/problems/design-browser-history/
/// </summary>
public class DesignBrowserHistory : BaseSolution
{
    public override void Solve()
    {
        Console.WriteLine("Ok");
    }
}

public class BrowserNode
{
    public BrowserNode(BrowserNode prev, string url)
    {
        Prev = prev;
        Url = url;
    }

    public BrowserNode Next { get; private set; }
    public BrowserNode Prev { get; }

    public string Url { get; private set; }

    public void SetNext(BrowserNode node)
    {
        Next = node;
    }
}

public class BrowserHistory
{
    private BrowserNode _currentNode;


    public BrowserHistory(string homepage)
    {
        _currentNode = new BrowserNode(null, homepage);
    }

    public void Visit(string url)
    {
        var nextNode = new BrowserNode(_currentNode, url);
        _currentNode.SetNext(nextNode);
        _currentNode = nextNode;
    }

    public string Back(int steps)
    {
        for (var i = 0; i < steps; i++)
            if (_currentNode.Prev != null)
                _currentNode = _currentNode.Prev;
            else
                break;

        return _currentNode.Url;
    }

    public string Forward(int steps)
    {
        for (var i = 0; i < steps; i++)
            if (_currentNode.Next != null)
                _currentNode = _currentNode.Next;
            else
                break;

        return _currentNode.Url;
    }
}
