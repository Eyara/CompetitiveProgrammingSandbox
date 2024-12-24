namespace SolutionRunner.MathProblems;

/// <summary>
///     https://codeforces.com/problemset/problem/1985/B
/// </summary>
public class B1985
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine());
        for (var i = 0; i < t; i++) Console.WriteLine($"{GetAnswer()}");
    }

    private static int GetAnswer()
    {
        var n = int.Parse(Console.ReadLine());

        var bestResult = 0;
        var bestNum = 0;

        for (var i = 2; i <= n; i++)
        {
            var currentResult = 0;
            for (var j = i; j <= n; j += i) currentResult += j;

            if (currentResult > bestResult)
            {
                bestResult = currentResult;
                bestNum = i;
            }
        }

        return bestNum;
    }
}