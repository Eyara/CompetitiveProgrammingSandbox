using SolutionRunner.Base;

namespace SolutionRunner.HashTable;

/// <summary>
///     https://leetcode.com/problems/word-pattern
/// </summary>
public class WordPatternSolution : BaseSolution
{
    public override void Solve()
    {
        Console.WriteLine(WordPattern("abba", "dog cat cat dog"));
    }

    public bool WordPattern(string pattern, string s)
    {
        var patternDict = new Dictionary<char, int>();
        var wordDict = new Dictionary<string, int>();

        var currentPatternCounter = 0;
        var currentWordCounter = 0;

        var words = s.Split(' ');

        if (words.Length != pattern.Length)
            return false;

        foreach (var ch in pattern)
            if (!patternDict.ContainsKey(ch))
            {
                patternDict[ch] = currentPatternCounter;
                currentPatternCounter++;
            }

        foreach (var word in words)
            if (!wordDict.ContainsKey(word))
            {
                wordDict[word] = currentWordCounter;
                currentWordCounter++;
            }

        for (var i = 0; i < words.Length; i++)
            if (patternDict[pattern[i]] != wordDict[words[i]])
                return false;

        return true;
    }
}