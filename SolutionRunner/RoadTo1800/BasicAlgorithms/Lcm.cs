namespace SolutionRunner.RoadTo1800.BasicAlgorithms;

public class Lcm
{
    public long LcmIterative(int a, int b)
    {
        if (a == 0 || b == 0) return 0;

        var gcd = new Gcd();
        return Math.Abs((long)a * b / gcd.GcdIterative(a, b));
    }

    public void Test()
    {
        var a = 1000000;
        var b = 2000000;

        Console.WriteLine(LcmIterative(a, b));
    }
}