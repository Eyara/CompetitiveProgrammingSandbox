namespace SolutionRunner.MathProblems;

/// <summary>
///     https://codeforces.com/problemset/problem/1933/b
/// </summary>
public class B1933 
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
        
        var numbers = Console.ReadLine().Split(' ');

        var arrSum = 0;
        var hasDivOne = false;

        for (var i = 0; i < n; i++)
        {
            var currentNum = int.Parse(numbers[i]);
            arrSum += currentNum;

            if (currentNum % 3 == 1)
            {
                hasDivOne = true;
            }
        }

        if (arrSum % 3 == 0)
        {
            return 0;
        }

        if (arrSum % 3 == 2)
        {
            return 1;
        }

        return hasDivOne ? 1 : 2;
    }

}