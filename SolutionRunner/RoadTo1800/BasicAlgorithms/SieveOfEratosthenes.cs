namespace SolutionRunner.RoadTo1800.BasicAlgorithms;

public class SieveOfEratosthenes
{
    public List<int> Solution(int n)
    {
        var arr = new bool[n + 1];

        for (var i = 2; i <= n; i++) arr[i] = true;

        for (var p = 2; p * p < n; p++)
            if (arr[p])
                for (var i = p * p; i <= n; i += p)
                    arr[i] = false;

        var result = new List<int>();

        for (var i = 2; i <= n; i++)
            if (arr[i])
                result.Add(i);

        return result;
    }

    public void Test()
    {
        var n = 30;

        var result = Solution(n);

        foreach (var res in result) Console.Write(res + " ");
    }
}