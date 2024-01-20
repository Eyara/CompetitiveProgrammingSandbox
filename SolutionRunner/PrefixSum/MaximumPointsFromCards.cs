using SolutionRunner.Base;

namespace SolutionRunner.PrefixSum;

/// <summary>
///     https://leetcode.com/problems/maximum-points-you-can-obtain-from-cards/
/// </summary>
public class MaximumPointsFromCards : BaseSolution
{
    public int MaxScore(int[] cardPoints, int k)
    {
        var n = cardPoints.Length;
        var prefixSum = new int[n + 1];

        for (var i = 0; i < n; i++)
            prefixSum[i + 1] = cardPoints[i] + prefixSum[i];

        var result = 0;
        var left = 0;

        for (var i = n - k; i <= n; i++) result = Math.Max(result, prefixSum[n] - prefixSum[i] + prefixSum[left++]);

        return result;
    }

    public override void Solve()
    {
        var input = Console.ReadLine();

        var numbers = input?.Split(',');

        var k = int.Parse(Console.ReadLine() ?? string.Empty);

        var nums = new int[numbers.Length];

        for (var i = 0; i < numbers.Length; i++) nums[i] = int.Parse(numbers[i]);

        Console.WriteLine(MaxScore(nums, k));
    }
}