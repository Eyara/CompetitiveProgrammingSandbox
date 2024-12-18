namespace SolutionRunner.MathProblems;

/// <summary>
///     https://codeforces.com/problemset/problem/2033/A
/// </summary>
public class A2033 
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine());
        for (var i = 0; i < t; i++)
        {
            Console.WriteLine($"{GetAnswer()}");
        }
    }

    private static string GetAnswer()
    {
        var n = int.Parse(Console.ReadLine());

        var x = 0;
        var i = 1;

        while (-n <= x && x <= n)
        {
            x += (2 * i - 1) * (i % 2 == 0 ? 1 : -1);
            i++;
        }

        if (x > 0)
        {
            return "Kosuke";
        }
        
        return "Sakurako";
    }
}