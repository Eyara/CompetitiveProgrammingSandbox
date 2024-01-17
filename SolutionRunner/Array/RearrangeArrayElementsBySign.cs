using SolutionRunner.Base;

namespace SolutionRunner.Array;

/// <summary>
///     https://leetcode.com/problems/rearrange-array-elements-by-sign/
/// </summary>
public class RearrangeArrayElementsBySign : BaseSolution
{
    public int[] RearrangeArray(int[] nums)
    {
        var pos_nums = new List<int>();
        var neg_nums = new List<int>();
        var result = new List<int>();

        for (var i = 0; i < nums.Length; i++)
            if (nums[i] > 0)
                pos_nums.Add(nums[i]);
            else
                neg_nums.Add(nums[i]);

        for (var i = 0; i < pos_nums.Count; i++)
        {
            result.Add(pos_nums[i]);
            result.Add(neg_nums[i]);
        }

        return result.ToArray();
    }

    public override void Solve()
    {
        var input = Console.ReadLine();

        var a = input?.Split(' ');
        var nums = new int[a.Length];

        for (var i = 0; i < a.Length; i++) nums[i] = int.Parse(a[i]);

        Console.WriteLine(RearrangeArray(nums));
    }
}