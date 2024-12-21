namespace SolutionRunner.MathProblems;

/// <summary>
///     https://codeforces.com/problemset/problem/1916/B
/// </summary>
public class B1916
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine());
        for (var i = 0; i < t; i++)
        {
            Console.WriteLine($"{GetAnswer()}");
        }
    }

    private static long GetAnswer()
    {
        var numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
        var a = numbers[0];
        var b = numbers[1];

        if (b % a == 0)
        {
            return b * b / a;
        }
        else
        {
            return b * a / (GcdIterative(a, b));
        }
    }
    
    private static long GcdIterative(long a, long b)
    {
        while (a != 0)
        {
            var a1 = a;
            a = b % a;
            b = a1;
        }

        return b;
    }

}