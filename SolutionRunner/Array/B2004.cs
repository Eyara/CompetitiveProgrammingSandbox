namespace SolutionRunner.Array;

/// <summary>
///     https://codeforces.com/problemset/problem/2004/B
/// </summary>
public class B2004
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine());
        for (var i = 0; i < t; i++) Console.WriteLine($"{GetAnswer()}");
    }

    private static int GetAnswer()
    {
        var alice = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        var bob = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        var aliceResult = 0;
        var bobResult = 0;

        if (alice[0] >= bob[0] || alice[1] <= bob[1])
            for (var i = alice[0]; i <= alice[1] && i <= bob[1]; i++)
                if (i + 1 >= bob[0] && i + 1 <= bob[1])
                    aliceResult++;

        aliceResult = Math.Max(aliceResult, 1);

        if (alice[0] > bob[0] && alice[1] < bob[1]) aliceResult++;

        // Bob result starting

        if (bob[0] >= alice[0] || bob[1] <= alice[1])
            for (var i = bob[0]; i <= bob[1] && i <= alice[1]; i++)
                if (i + 1 >= alice[0] && i + 1 <= alice[1])
                    bobResult++;

        bobResult = Math.Max(bobResult, 1);

        if (bob[0] > alice[0] && bob[1] < alice[1]) bobResult++;

        return Math.Max(aliceResult, bobResult);
    }
}