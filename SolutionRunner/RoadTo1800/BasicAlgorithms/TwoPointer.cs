namespace SolutionRunner.RoadTo1800.BasicAlgorithms;

public class TwoPointer
{
    // example with finding existing of sum of two equals to target
    public bool TwoPointerTechnique(int[] arr, int target)
    {
        var left = 0;
        var right = arr.Length - 1;

        while (left < right)
        {
            if (arr[left] + arr[right] < target)
            {
                left++;
            }
            else if (arr[left] + arr[right] > target)
            {
                right--;
            }
            else
            {
                return true;
            }
        }

        return false;
    }

    public void Test()
    {
        var arr1 = new int[] { 10, 20, 30, 50, 70 };
        var target1 = 70;
        
        var arr2 = new int[] { 10, 20, 30 };
        
        var arr3 = new int[] { -8, 1, 4, 6, 10, 45 };
        var target3 = 16;
        
        Console.WriteLine(TwoPointerTechnique(arr1, target1));
        Console.WriteLine(TwoPointerTechnique(arr2, target1));
        Console.WriteLine(TwoPointerTechnique(arr3, target3));
    }
}