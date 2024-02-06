using SolutionRunner.Base;

namespace SolutionRunner.HashTable;

/// <summary>
///     https://leetcode.com/problems/rank-teams-by-votes/
/// </summary>
public class RankTeamsByVotes : BaseSolution
{
    public override void Solve()
    {
        Console.WriteLine(RankTeams(new[] { "ABC", "ACB", "ABC", "ACB", "ACB" }));
    }

    public string RankTeams(string[] votes)
    {
        var rankDict = new Dictionary<char, int[]>();

        foreach (var ch in votes[0]) rankDict[ch] = new int[votes[0].Length];

        foreach (var vote in votes)
        {
            for (var j = 0; j < vote.Length; j++)
            {
                rankDict[vote[j]][j] += 1;
            }
        }

        var rankedQuery = rankDict.OrderByDescending(x => x.Value[0]);

        for (var i = 0; i < votes[0].Length; i++)
        {
            int i1 = i;
            rankedQuery = rankedQuery.ThenByDescending(x => x.Value[i1]);
        }

        var finalDict = rankedQuery.ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

        return string.Join("", finalDict.Keys);
    }
}