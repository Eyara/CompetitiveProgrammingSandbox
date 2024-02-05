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
        var hashSet = new HashSet<int>();

        foreach (var num in nums)
        {
            if (hashSet.Contains(num))
            {
                return true;
            }
            else
            {
                hashSet.Add(num);
            }
        }

        return false;
    }
}