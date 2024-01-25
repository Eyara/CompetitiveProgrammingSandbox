using SolutionRunner.Base;

namespace SolutionRunner.PrefixSum;

/// <summary>
///     https://leetcode.com/problems/sum-of-all-odd-length-subarrays/
/// </summary>
public class SumOfAllOddLengthSubarrays : BaseSolution
{
    public override void Solve()
    {
        var input = Console.ReadLine();

        var numbers = input?.Split(',');

        var nums = new int[numbers.Length];

        for (var i = 0; i < numbers.Length; i++) nums[i] = int.Parse(numbers[i]);

        Console.WriteLine(SumOddLengthSubarrays(nums));
    }

    public int SumOddLengthSubarrays(int[] arr)
    {
        var n = arr.Length;
        var sum = 0;

        for (var i = 0; i < n; i++) sum += ((i + 1) * (n - i) + 1) / 2 * arr[i];

        return sum;
    }
}