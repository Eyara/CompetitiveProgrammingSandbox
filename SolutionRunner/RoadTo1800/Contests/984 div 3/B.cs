namespace SolutionRunner.RoadTo1800.Contests._984_div_3;

/// <summary>
///     https://codeforces.com/contest/2036/problem/B
/// </summary>
public class B
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine());

        for (var i = 0; i < t; i++) Solve();
    }

    private static void Solve()
    {
        var a = new int[2];

        var numbers = Console.ReadLine()?.Split(' ');

        for (var i = 0; i < a.Length; i++) a[i] = int.Parse(numbers[i]);

        var n = a[0];
        var k = a[1];
        var dictBottles = new Dictionary<int, int>();

        for (var i = 0; i < k; i++)
        {
            numbers = Console.ReadLine()?.Split(' ');
            for (var j = 0; j < a.Length; j++) a[j] = int.Parse(numbers[j]);
            var b = a[0];
            var c = a[1];

            if (dictBottles.ContainsKey(b))
                dictBottles[b] += c;
            else
                dictBottles.Add(b, c);
        }

        var sortedDict = dictBottles.OrderByDescending(entry => entry.Value);
        Console.WriteLine(sortedDict.Take(n).Sum(x => x.Value));
    }
}