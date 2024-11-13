using System.Text;

namespace SolutionRunner.RoadTo1800.Contests._984_div_3;

/// <summary>
/// https://codeforces.com/contest/2036/problem/C
/// </summary>
public class C
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine());

        for (var i = 0; i < t; i++) Solve();
    }

    private static void Solve()
    {
        var sb = new StringBuilder(Console.ReadLine());
        var n = int.Parse(Console.ReadLine());

        var occurCount = 0;

        for (var i = 0; i < sb.Length - 3; i++)
        {
            if (CheckOccur(sb, i))
            {
                occurCount++;
            }
        }

        for (var i = 0; i < n; i++)
        {
            var operation = Console.ReadLine()?.Split(' ');
            var index = int.Parse(operation[0]) - 1;
            
            var hadOccur = CheckOccur(sb, index - 3) || CheckOccur(sb, index - 2) || CheckOccur(sb, index - 1) || CheckOccur(sb, index);

            sb[index] = operation[1].ToCharArray().First();

            var nowOccur = CheckOccur(sb, index - 3) || CheckOccur(sb, index - 2) || CheckOccur(sb, index - 1) || CheckOccur(sb, index);

            if (hadOccur && !nowOccur)
            {
                occurCount--;
            }
            else if (!hadOccur && nowOccur)
            {
                occurCount++;
            }

            if (occurCount > 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }

    private static bool CheckOccur(StringBuilder sb, int i)
    {
        if (i < 0) return false;
        if (i >= sb.Length - 3) return false;

        return sb[i] == '1' && sb[i + 1] == '1' && sb[i + 2] == '0' && sb[i + 3] == '0';
    }
}