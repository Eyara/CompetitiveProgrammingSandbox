namespace SolutionRunner.MathProblems;

/// <summary>
///     https://codeforces.com/problemset/problem/2047/A
/// </summary>
public class A2047 
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
        var n = int.Parse(Console.ReadLine());
        var a = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();
        
        var currentNum = 0;
        var result = 0;
        

        for (var i = 0; i < n; i++)
        {
            currentNum += a[i];

            if (Math.Sqrt(currentNum) % 1 == 0 && Math.Sqrt(currentNum) % 2 == 1)
            {
                result++;
            }
        }

        return result;
    }

}