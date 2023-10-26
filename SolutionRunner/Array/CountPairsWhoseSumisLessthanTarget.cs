using SolutionRunner.Base;

namespace SolutionRunner.Array;

/// <summary>
/// https://leetcode.com/problems/count-pairs-whose-sum-is-less-than-target
/// </summary>
public class CountPairsWhoseSumIsLessThanTarget : BaseSolution
{
    private int CountPairs(IList<int> nums, int target)
    {
        var result = 0;
        for (int i = 0; i < nums.Count; i++)
        {
            for (int j = i + 1; j < nums.Count; j++)
            {
                if (nums[i] + nums[j] < target)
                {
                    result++;
                }
            }
        }

        return result;
    }

    public override void Solve()
    {
        var input = Console.ReadLine();

        var numbers = input?.Split(' ');
        var nums = new int[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            nums[i] = int.Parse(numbers[i]);
        }

        input = Console.ReadLine();

        var target = Convert.ToInt32(input);

        Console.WriteLine(CountPairs(nums, target));
    }
}