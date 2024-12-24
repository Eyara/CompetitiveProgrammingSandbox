namespace SolutionRunner.Array;

/// <summary>
///     https://codeforces.com/problemset/problem/1985/C
/// </summary>
public class C1985
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine());
        for (var i = 0; i < t; i++) Console.WriteLine($"{GetAnswer()}");
    }

    private static long GetAnswer()
    {
        var n = int.Parse(Console.ReadLine());

        var a = Console.ReadLine()
            .Split(' ')
            .Select(long.Parse)
            .ToList();

        var result = 0;
        long currentSum = 0;
        long currentMax = 0;

        for (var i = 0; i < n; i++)
        {
            if (currentMax > a[i])
            {
                if (currentSum - currentMax + a[i] == currentMax) result++;
            }
            else
            {
                if (currentSum == a[i]) result++;
            }

            currentSum += a[i];
            currentMax = Math.Max(currentMax, a[i]);
        }

        return result;
    }
}