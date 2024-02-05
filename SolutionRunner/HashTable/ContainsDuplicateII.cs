using SolutionRunner.Base;

namespace SolutionRunner.HashTable;

/// <summary>
///     https://leetcode.com/problems/contains-duplicate-ii/
/// </summary>
public class ContainsDuplicateIISolution : BaseSolution
{
    public override void Solve()
    {
        Console.WriteLine(ContainsNearbyDuplicate(new[] { 1, 2, 3, 1 }, 3));
    }

    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        for (var i = 0; i < nums.Length; i++)
        for (var j = i + 1; j < Math.Min(nums.Length, i + k + 1); j++)
            if (nums[i] == nums[j])
                return true;

        return false;
    }
}