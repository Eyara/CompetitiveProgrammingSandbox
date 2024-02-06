using SolutionRunner.Base;

namespace SolutionRunner.HashTable;

/// <summary>
///     https://leetcode.com/problems/find-all-duplicates-in-an-array/
/// </summary>
public class FindAllDuplicatesInArray : BaseSolution
{
    public override void Solve()
    {
        Console.WriteLine(FindDuplicates(new[] { 4,3,2,7,8,2,3,1 }));
    }

    public IList<int> FindDuplicates(int[] nums)
    {
        var numsDict = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (numsDict.ContainsKey(num))
            {
                numsDict[num] += 1;
            }
            else
            {
                numsDict[num] = 0;
            }
        }

        return numsDict.Where(x => x.Value == 1).Select(x => x.Key).ToList();
    }
}