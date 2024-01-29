using System.Text;
using SolutionRunner.Base;

namespace SolutionRunner.HashTable;

/// <summary>
///     https://leetcode.com/problems/roman-to-integer
/// </summary>
public class RomanToInteger : BaseSolution
{
    public override void Solve()
    {
        var input = Console.ReadLine();

        Console.WriteLine(RomanToInt(input));
    }

    public int RomanToInt(string s)
    {
        var romanToIntDict = new Dictionary<string, int>
        {
            { "I", 1 },
            { "V", 5 },
            { "X", 10 },
            { "L", 50 },
            { "C", 100 },
            { "D", 500 },
            { "M", 1000 },
            { "IV", 4 },
            { "IX", 9 },
            { "XL", 40 },
            { "XC", 90 },
            { "CD", 400 },
            { "CM", 900 }
        };

        var sb = new StringBuilder();
        var result = 0;

        for (var i = 0; i < s.Length; i++)
            if (i + 1 < s.Length)
            {
                sb.Clear();
                sb.Append(s[i]);
                sb.Append(s[i + 1]);
                if (romanToIntDict.ContainsKey(sb.ToString()))
                {
                    result += romanToIntDict[sb.ToString()];
                    i++;
                }
                else
                {
                    result += romanToIntDict[s[i].ToString()];
                }
            }
            else
            {
                result += romanToIntDict[s[i].ToString()];
            }

        return result;
    }
}