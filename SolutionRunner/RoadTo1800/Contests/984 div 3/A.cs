namespace SolutionRunner.RoadTo1800.Contests._984_div_3;

/// <summary>
/// https://codeforces.com/contest/2036/problem/A
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
        var n = int.Parse(Console.ReadLine());
        
        var a = new int[n];

        var numbers = Console.ReadLine()?.Split(' ');

        for (var i = 0; i < a.Length; i++) a[i] = int.Parse(numbers[i]);

        for (var i = 0; i < a.Length - 1; i++)
        {
            var diff = Math.Abs(a[i] - a[i + 1]);
            if (diff != 5 && diff != 7)
            {
                Console.WriteLine("NO");
                return;
                ;
            }
        }
        
        Console.WriteLine("YES");
    }
}