namespace SolutionRunner.Array;

/// <summary>
///     https://codeforces.com/problemset/problem/1894/B
/// </summary>
public class B1894
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine());
        for (var i = 0; i < t; i++) GetAnswer();
    }

    private static void GetAnswer()
    {
        var n = int.Parse(Console.ReadLine());

        var a = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        if (n < 3)
        {
            Console.WriteLine(-1);
            return;
            ;
        }

        var resultIdxs = new List<Tuple<int, int>>();

        for (var i = 0; i < n; i++)
        {
            if (resultIdxs.Any() && a[resultIdxs[0].Item1] == a[i]) continue;
            for (var j = i; j < n; j++)
            {
                if (i == j) continue;

                if (a[i] == a[j])
                    if (!resultIdxs.Any() || (resultIdxs[0].Item1 != j && resultIdxs[0].Item2 != i))
                    {
                        resultIdxs.Add(new Tuple<int, int>(i, j));
                        break;
                    }

                if (resultIdxs.Count > 1) break;
            }

            if (resultIdxs.Count > 1) break;
        }

        if (resultIdxs.Count < 2)
        {
            Console.WriteLine(-1);
            return;
        }

        var result = Enumerable.Repeat(1, n).ToList();

        result[resultIdxs[0].Item1] = 2;
        result[resultIdxs[1].Item1] = 3;

        Console.WriteLine(string.Join(' ', result));
    }
}