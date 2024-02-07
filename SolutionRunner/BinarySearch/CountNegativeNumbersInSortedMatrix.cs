using SolutionRunner.Base;

namespace SolutionRunner.BinarySearch;

/// <summary>
///     https://leetcode.com/problems/count-negative-numbers-in-a-sorted-matrix/
/// </summary>
public class CountNegativeNumbersInSortedMatrix : BaseSolution
{
    public override void Solve()
    {
        Console.WriteLine(CountNegatives(new[]
        {
            new[] { 4, 3, 2, -1 },
            new[] { 3, 2, 1, -1 },
            new[] { 1, 1, -1, -2 },
            new[] { -1, -1, -2, -3 }
        }));
    }

    public int CountNegatives(int[][] grid)
    {
        var result = 0;

        foreach (var arr in grid)
            result += BinarySearchNegativeCount(arr);

        return result;
    }

    private int BinarySearchNegativeCount(int[] arr)
    {
        var left = 0;
        var right = arr.Length - 1;

        if (arr[right] >= 0) return 0;
        
        while (left <= right)
        {
            var mid = (right - left) / 2 + left;
            if (arr[mid] < 0)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return arr.Length - left;
    }


    [Obsolete]
    public int CountNegativesNaive(int[][] grid)
    {
        var numList = new List<int>();
        var result = 0;

        foreach (var arr in grid) numList.AddRange(arr);

        numList.Sort();

        var i = 0;
        while (true)
        {
            if (i < numList.Count && numList[i] < 0)
            {
                result++;
                i++;
                continue;
            }

            break;
        }

        return result;
    }
}