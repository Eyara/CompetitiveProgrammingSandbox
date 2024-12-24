namespace SolutionRunner.String;

/// <summary>
///     https://codeforces.com/problemset/problem/2039/B
/// </summary>
public class B2039
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine());
        for (var i = 0; i < t; i++) Console.WriteLine($"{GetAnswer()}");
    }

    private static string GetAnswer()
    {
        var s = Console.ReadLine();
        var n = s.Length;

        for (var i = 0; i < n - 1; i++)
            if (s[i] == s[i + 1])
                return s.Substring(i, 2);

        for (var i = 0; i < n - 2; i++)
            if (s[i] != s[i + 1] && s[i + 1] != s[i + 2] && s[i] != s[i + 2])
                return s.Substring(i, 3);

        return "-1";
    }
}