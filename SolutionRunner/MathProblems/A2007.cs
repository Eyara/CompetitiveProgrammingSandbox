namespace SolutionRunner.MathProblems;

/// <summary>
///     https://codeforces.com/problemset/problem/2007/A
/// </summary>
public class A2007 
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine());
        for (var i = 0; i < t; i++)
        {
            Console.WriteLine($"{GetAnswer()}");
        }
    }

    private static int GetAnswer()
    {
        var numbers = Console.ReadLine().Split(' ');
        var start = int.Parse(numbers[0]);
        var end = int.Parse(numbers[1]);
        return ((end + 1) / 2  - start / 2) / 2;
    }

}