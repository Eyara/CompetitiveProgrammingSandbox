using SolutionRunner.Base;

namespace SolutionRunner.HashTable;

/// <summary>
///     https://leetcode.com/problems/bulls-and-cows/
/// </summary>
public class BullsAndCows : BaseSolution
{
    public override void Solve()
    {
        Console.WriteLine(GetHint("1123", "0111"));
    }

    public string GetHint(string secret, string guess)
    {
        var secretDict = new Dictionary<int, List<int>>();
        var guessDict = new Dictionary<int, List<int>>();

        var bulls = 0;
        var cows = 0;

        for (var i = 0; i < secret.Length; i++)
        {
            var currentNum = Convert.ToInt32(secret[i]);

            if (!secretDict.ContainsKey(currentNum)) secretDict[currentNum] = new List<int>();

            secretDict[currentNum].Add(i);


            currentNum = Convert.ToInt32(guess[i]);

            if (!guessDict.ContainsKey(currentNum)) guessDict[currentNum] = new List<int>();

            guessDict[currentNum].Add(i);
        }

        foreach (var keyValuePair in guessDict)
            if (secretDict.ContainsKey(keyValuePair.Key))
            {
                var correctAnswersCount = secretDict[keyValuePair.Key].Intersect(keyValuePair.Value)?.Count();

                if (correctAnswersCount.HasValue)
                {
                    bulls += correctAnswersCount.Value;
                    cows += Math.Min(secretDict[keyValuePair.Key].Count() - correctAnswersCount.Value,
                        keyValuePair.Value.Count - correctAnswersCount.Value);
                }
            }

        return $"{bulls}A{cows}B";
    }
}