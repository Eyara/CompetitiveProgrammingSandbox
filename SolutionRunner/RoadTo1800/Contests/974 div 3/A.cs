namespace SolutionRunner.RoadTo1800.Contests._974_div_3;

/// <summary>
///     https://codeforces.com/contest/2014/problem/A
/// </summary>
public class A
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine());

        for (var i = 0; i < t; i++) Solve();
    }

    private static void Solve()
    {
        var input = Console.ReadLine()?.Split(' ');
        var n = int.Parse(input[0]);
        var k = int.Parse(input[1]);

        var a = new int[n];
        var currentMoney = 0;
        var result = 0;

        var numbers = Console.ReadLine()?.Split(' ');

        for (var i = 0; i < a.Length; i++) a[i] = int.Parse(numbers[i]);

        for (var i = 0; i < n; i++)
            if (a[i] >= k)
            {
                currentMoney += a[i];
            }
            else
            {
                if (a[i] == 0 && currentMoney > 0)
                {
                    currentMoney--;
                    result++;
                }
            }

        Console.WriteLine(result);
    }
}