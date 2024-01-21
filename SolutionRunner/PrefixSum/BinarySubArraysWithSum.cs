using SolutionRunner.Base;

namespace SolutionRunner.PrefixSum;

/// <summary>
///     https://leetcode.com/problems/binary-subarrays-with-sum/
/// </summary>
public class BinarySubArraysWithSum : BaseSolution
{
    public override void Solve()
    {
        var input = Console.ReadLine();

        var numbers = input?.Split(',');

        var k = int.Parse(Console.ReadLine() ?? string.Empty);

        var nums = new int[numbers.Length];

        for (var i = 0; i < numbers.Length; i++) nums[i] = int.Parse(numbers[i]);

        Console.WriteLine(NumSubarraysWithSum(nums, k));
    }

    public int NumSubarraysWithSum(int[] nums, int goal)
    {
        var prefixSums = new int[nums.Length];
        var prefixDict = new Dictionary<int, int>();
        prefixDict.Add(0, 1);

        for (var i = 0; i < nums.Length; i++) prefixSums[i] = nums[i] + (i > 0 ? prefixSums[i - 1] : 0);

        var result = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var ps = prefixSums[i];

            var diff = ps - goal;
            if (prefixDict.ContainsKey(diff)) result += prefixDict[diff];
            if (prefixDict.ContainsKey(ps))
                prefixDict[ps]++;
            else
                prefixDict.Add(ps, 1);
        }

        return result;
    }
}