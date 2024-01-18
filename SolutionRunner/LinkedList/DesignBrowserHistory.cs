using SolutionRunner.Base;

namespace SolutionRunner.LinkedList;

/// <summary>
///     https://leetcode.com/problems/design-browser-history/
/// </summary>
public class DesignBrowserHistory : BaseSolution
{
    public override void Solve()
    {
        var browserHistory = new BrowserHistory("leetcode.com");
        browserHistory.Visit("google.com");
        browserHistory.Visit("facebook.com");
        browserHistory.Visit("youtube.com");
        browserHistory.Back(1);
        browserHistory.Back(1);
        browserHistory.Forward(1);
        browserHistory.Visit("linkedin.com");
        browserHistory.Forward(2);
        browserHistory.Back(2);
        browserHistory.Back(7);
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

    public string Url { get; }

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
