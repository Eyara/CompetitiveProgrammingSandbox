using SolutionRunner.Base;

namespace SolutionRunner.Array;

/// <summary>
///     https://leetcode.com/problems/find-good-days-to-rob-the-bank/
/// </summary>
public class FindGoodDaysToRobTheBank : BaseSolution
{
    public override void Solve()
    {
        var input = Console.ReadLine();

        var numbers = input?.Split(',');
        var security = new int[numbers.Length];

        for (var i = 0; i < numbers.Length; i++) security[i] = int.Parse(numbers[i]);

        var time = int.Parse(Console.ReadLine());

        Console.WriteLine(GoodDaysToRobBank(security, time));
    }

    public IList<int> GoodDaysToRobBank(int[] security, int time)
    {
        var n = security.Length;
        var daysBefore = new int[n];
        var daysAfter = new int[n];
        var results = new List<int>();

        var currentSeq = 0;

        for (var i = 0; i < n; i++)
        {
            currentSeq = i - 1 >= 0 && security[i] <= security[i - 1] ? currentSeq + 1 : 0;
            daysBefore[i] = currentSeq;
        }

        currentSeq = 0;

        for (var i = n - 1; i >= 0; i--)
        {
            currentSeq = i + 1 < n && security[i] <= security[i + 1] ? currentSeq + 1 : 0;
            daysAfter[i] = currentSeq;
        }

        for (var i = 0; i < n; i++)
            if (daysBefore[i] >= time && daysAfter[i] >= time)
                results.Add(i);

        return results;
    }
}