namespace SolutionRunner.String;

/// <summary>
///     https://codeforces.com/problemset/problem/2034/B
/// </summary>
public class B2034
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine());
        for (var i = 0; i < t; i++)
        {
            Console.WriteLine($"{GetAnswer()}");
        }
    }

    private static int GetAnswer()
    {
        var nmk = Console.ReadLine().Split(' ');
        var s = Console.ReadLine();

        var n = int.Parse(nmk[0]);
        var m = int.Parse(nmk[1]);
        var k = int.Parse(nmk[2]);

        var arrSeq = new List<Tuple<int, int>>();

        var isSeq = false;
        var seqLength = 0;
        var result = 0;

        for (var i = 0; i < n; i++)
        {
            if (s[i] == '0')
            {
                isSeq = true;
                seqLength++;

                if (seqLength >= m)
                {
                    i += k - 1;
                    result++;
                    isSeq = false;
                    seqLength = 0;
                }
            }
            else
            {
                if (isSeq)
                {
                    isSeq = false;
                    seqLength = 0;
                }
            }
        }

        return result;
    }
}