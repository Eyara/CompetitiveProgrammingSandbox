namespace SolutionRunner.String;

/// <summary>
///     https://codeforces.com/problemset/problem/2005/B1
/// </summary>
public class B12005
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine());
        for (var i = 0; i < t; i++) Console.WriteLine($"{GetAnswer()}");
    }

    private static int GetAnswer()
    {
        var nmq = Console.ReadLine().Split(' ');
        var b = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        b.Sort();
        var a = int.Parse(Console.ReadLine());

        var n = int.Parse(nmq[0]);
        var m = int.Parse(nmq[1]);
        var q = int.Parse(nmq[2]);

        var rIndex = NextLargestOrEqualIterative(b.ToArray(), a);
        var r = b[rIndex >= 0 ? rIndex : b.Count - 1];
        var l = rIndex <= 0 ? -1 : b[rIndex - 1];

        var result = 0;

        if (rIndex >= 0)
        {
            if (l >= 0)
                result = (r - l) / 2;
            else
                result = r - 1;
        }
        else
        {
            result = n - r;
        }


        return Math.Max(result, 1);
    }

    private static int NextLargestOrEqualIterative(int[] sortedArray, int target)
    {
        var high = sortedArray.Length - 1;
        var low = 0;
        var nextLargest = -1;

        while (low <= high)
        {
            var mid = low + (high - low) / 2;

            if (sortedArray[mid] == target) return mid;

            if (sortedArray[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                nextLargest = mid;
                high = mid - 1;
            }
        }

        return nextLargest;
    }
}