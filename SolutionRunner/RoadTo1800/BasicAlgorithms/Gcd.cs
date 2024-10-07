namespace SolutionRunner.RoadTo1800.BasicAlgorithms;

public class Gcd
{
    public int GcdRecursion(int a, int b)
    {
        if (a == 0) return b;

        return GcdRecursion(b % a, a);
    }

    // preferable
    public int GcdIterative(int a, int b)
    {
        while (a != 0)
        {
            var a1 = a;
            a = b % a;
            b = a1;
        }

        return b;
    }

    public void Test()
    {
        var a = 5;
        var b = 10;

        var a1 = 12;
        var b1 = 36;
        
        Console.WriteLine(GcdRecursion(a, b));
        Console.WriteLine(GcdIterative(a, b));
        
        Console.WriteLine(GcdRecursion(a1, b1));
        Console.WriteLine(GcdIterative(a1, b1));
    }
}