using SolutionRunner.Base;

namespace SolutionRunner.Array;

/// <summary>
/// https://leetcode.com/problems/height-checker/
/// </summary>
public class HeightCheckerSolution : BaseSolution
{
    private int HeightChecker(int[] heights)
    {
        var heightsList = new List<int>(heights);
        heightsList.Sort();

        var result = 0;

        for (int i = 0; i < heights.Length; i++)
        {
            if (heights[i] != heightsList[i])
            {
                result++;
            }
        }

        return result;
    }

    public override void Solve()
    {
        var input = Console.ReadLine();

        var numbers = input?.Split(' ');
        var heights = new int[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            heights[i] = int.Parse(numbers[i]);
        }

        Console.WriteLine(HeightChecker(heights));
    }
}