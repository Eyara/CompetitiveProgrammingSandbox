using SolutionRunner.Base;

namespace SolutionRunner.MathProblems;

/// <summary>
///     https://leetcode.com/problems/ugly-number
/// </summary>
public class UglyNumberSolution : BaseSolution
{
    public override void Solve()
    {
        Console.WriteLine(IsUgly(-2147483648));
    }

    public bool IsUgly(int n)
    {
        if (n <= 0) return false;
        while (n > 1)
            if (n % 2 == 0)
                n /= 2;
            else if (n % 3 == 0)
                n /= 3;
            else if (n % 5 == 0)
                n /= 5;
            else return false;

        return true;
    }
}