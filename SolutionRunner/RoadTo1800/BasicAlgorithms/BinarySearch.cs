namespace SolutionRunner.RoadTo1800.BasicAlgorithms;

public class BinarySearch
{
    public int BasicIterative(int[] sortedArray, int target)
    {
        var high = sortedArray.Length - 1;
        var low = 0;

        while (low <= high)
        {
            var mid = low + (high - low) / 2;

            if (sortedArray[mid] == target) return mid;

            if (sortedArray[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return -1;
    }

    public int NextLargestOrEqualIterative(int[] sortedArray, int target)
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

    public void Test()
    {
        Console.WriteLine(NextLargestOrEqualIterative(new[] { 0, 2, 5, 8, 9, 11, 12 }, 10));
    }
}