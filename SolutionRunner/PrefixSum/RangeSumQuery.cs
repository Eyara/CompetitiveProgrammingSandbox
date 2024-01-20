using SolutionRunner.Base;

namespace SolutionRunner.PrefixSum;

/// <summary>
///     https://leetcode.com/problems/range-sum-query-immutable/
/// </summary>
public class RangeSumQuery : BaseSolution
{
    public override void Solve()
    {
        var input = Console.ReadLine();

        var numbers = input?.Split(',');

        input = Console.ReadLine();

        var rangeString = input?.Split(',');

        var nums = new int[numbers.Length];
        var range = new int[rangeString.Length];

        for (var i = 0; i < numbers.Length; i++) nums[i] = int.Parse(numbers[i]);
        for (var i = 0; i < rangeString.Length; i++) range[i] = int.Parse(rangeString[i]);

        var numArray = new NumArray(nums);
        Console.WriteLine(numArray.SumRange(range[0], range[1]));
    }
}

public class NumArray
{
    private readonly int[] _prefixNums;

    public NumArray(int[] nums)
    {
        _prefixNums = new int[nums.Length];

        for (var i = 0; i < nums.Length; i++) _prefixNums[i] = nums[i] + (i > 0 ? _prefixNums[i - 1] : 0);
    }

    public int SumRange(int left, int right)
    {
        return _prefixNums[right] - (left > 0 ? _prefixNums[left - 1] : 0);
    }
}