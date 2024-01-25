using SolutionRunner.Base;

namespace SolutionRunner.PrefixSum;

/// <summary>
///     https://leetcode.com/problems/running-sum-of-1d-array/
/// </summary>
public class RunningSumof1dArray : BaseSolution
{
    public override void Solve()
    {
        var input = Console.ReadLine();

        var numbers = input?.Split(',');

        var nums = new int[numbers.Length];

        for (var i = 0; i < numbers.Length; i++) nums[i] = int.Parse(numbers[i]);

        Console.WriteLine(RunningSum(nums));
    }

    public int[] RunningSum(int[] nums)
    {
        var prefixSum = new int[nums.Length];

        for (var i = 0; i < nums.Length; i++) prefixSum[i] = nums[i] + (i > 0 ? prefixSum[i - 1] : 0);

        return prefixSum;
    }
}