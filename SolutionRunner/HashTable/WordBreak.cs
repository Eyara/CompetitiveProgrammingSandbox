using SolutionRunner.Base;

namespace SolutionRunner.HashTable;

/// <summary>
///     https://leetcode.com/problems/word-break/
/// </summary>
public class WordBreakSolution : BaseSolution
{
    private readonly Dictionary<string, bool> _memoDict = new();

    public override void Solve()
    {
        Console.WriteLine(WordBreak("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab",
            new List<string> { "a","aa","aaa","aaaa","aaaaa","aaaaaa","aaaaaaa","aaaaaaaa","aaaaaaaaa","aaaaaaaaaa" }));
    }

    public bool WordBreak(string s, IList<string> wordDict)
    {
        return CheckSubString(s, wordDict);
    }

    private bool CheckSubString(string s, IList<string> wordDict)
    {
        if (_memoDict.ContainsKey(s)) return _memoDict[s];
        foreach (var word in wordDict)
            if (s.StartsWith(word))
            {
                var newS = s.Substring(word.Length);
                if (newS.Length == 0)
                {
                    _memoDict.TryAdd(word, true);
                    return true;
                }

                if (CheckSubString(newS, wordDict))
                    return true;
            }

        _memoDict.TryAdd(s, false);
        return false;
    }
}