using SolutionRunner.Base;

namespace SolutionRunner.Array;

/// <summary>
///     https://leetcode.com/problems/maximum-population-year/
/// </summary>
public class MaximumPopulationYear : BaseSolution
{
    public override void Solve()
    {
        // too complicated input to spend time on it by reading from a console

        var testLogs = new[]
        {
            new[]
            {
                1950, 1961
            },
            new[]
            {
                1960, 1971
            },
            new[]
            {
                1970, 1981
            }
        };

        Console.WriteLine(MaximumPopulation(testLogs));
    }

    public int MaximumPopulation(int[][] logs)
    {
        var populationDict = new Dictionary<int, int>();

        for (var i = 0; i < logs.Length; i++)
        {
            var birth = logs[i][0];
            var death = logs[i][1];

            for (var currentYear = birth; currentYear < death; currentYear++)
                if (populationDict.ContainsKey(currentYear))
                    populationDict[currentYear] += 1;
                else
                    populationDict[currentYear] = 1;
        }

        populationDict = populationDict.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary();
        return populationDict.First().Key;
    }
}