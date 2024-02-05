using SolutionRunner.Base;

namespace SolutionRunner.HashTable;

/// <summary>
///     https://leetcode.com/problems/contains-duplicate/
/// </summary>
public class ContainsDuplicateSolution : BaseSolution
{
    public override void Solve()
    {
        Console.WriteLine(ContainsDuplicate(new int[] {1,2,3,4}));
    }

    public bool ContainsDuplicate(int[] nums)
    {
        var dict = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (dict.ContainsKey(num))
            {
                return true;
            }
            else
            {
                dict[num] = 1;
            }
        }

        return false;
    }
}