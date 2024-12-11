namespace SolutionRunner.MathProblems;

/// <summary>
///     https://codeforces.com/problemset/problem/1899/A
/// </summary>
public class A1899 
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

        return n % 3 == 0 ? "Second" : "First"; 
    }

}