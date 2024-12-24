namespace SolutionRunner.Array;

/// <summary>
///     https://codeforces.com/problemset/problem/1987/B
/// </summary>
public class B1987
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

        var underValues = new List<long>();
        var currentMax = a[0];
        for (var i = 1; i < n; i++)
            if (a[i] < currentMax)
                underValues.Add(currentMax - a[i]);
            else
                currentMax = a[i];

        if (!underValues.Any()) return 0;

        return underValues.Sum() + underValues.Max();
    }
}