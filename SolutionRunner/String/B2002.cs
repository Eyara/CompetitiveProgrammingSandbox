namespace SolutionRunner.String;

/// <summary>
///     https://codeforces.com/problemset/problem/2002/B
/// </summary>
public class B2002
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
        var a = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();
        var b = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        if (a.SequenceEqual(b))
        {
            return "Bob";
        }

        b.Reverse();
        
        if (a.SequenceEqual(b))
        {
            return "Bob";
        }

        return "Alice";
    }
}