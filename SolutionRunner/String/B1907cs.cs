using System.Text;

namespace SolutionRunner.String;

/// <summary>
///     https://codeforces.com/problemset/problem/1907/B
/// </summary>
public class B1907
{
    public static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine());
        for (var i = 0; i < t; i++) Console.WriteLine($"{GetAnswer()}");
    }

    private static string GetAnswer()
    {
        var strBaseList = new List<Tuple<char, int>>();
        var lowerInstructionsList = new List<int>();
        var upperInstructionsList = new List<int>();

        var s = Console.ReadLine();

        var sb = new StringBuilder();

        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == 'b')
            {
                lowerInstructionsList.Add(i);
                continue;
            }

            if (s[i] == 'B')
            {
                upperInstructionsList.Add(i);
                continue;
            }

            strBaseList.Add((new Tuple<char, int>(s[i], i)));
        }

        strBaseList.Reverse();
        lowerInstructionsList.Reverse();
        upperInstructionsList.Reverse();

        var currentLowerIdx = 0;
        var currentUpperIdx = 0;

        for (var i = 0; i < strBaseList.Count; i++)
        {
            var currentCharItem = strBaseList[i];

            if (char.IsUpper(currentCharItem.Item1))
            {
                if (currentUpperIdx < upperInstructionsList.Count)
                {
                    var currentUpperInstruction = upperInstructionsList[currentUpperIdx];

                    if (currentCharItem.Item2 < currentUpperInstruction)
                    {
                        currentUpperIdx++;
                    }
                    else
                    {
                        sb.Append(currentCharItem.Item1);    
                    }
                }
                else
                {
                    sb.Append(currentCharItem.Item1);
                }
            }
            
            if (char.IsLower(currentCharItem.Item1))
            {
                if (currentLowerIdx < lowerInstructionsList.Count)
                {
                    var currentLowerInstruction = lowerInstructionsList[currentLowerIdx];

                    if (currentCharItem.Item2 < currentLowerInstruction)
                    {
                        currentLowerIdx++;
                    }
                    else
                    {
                        sb.Append(currentCharItem.Item1);    
                    }
                }
                else
                {
                    sb.Append(strBaseList[i].Item1);
                }
            }
        }

        return string.Join(string.Empty, sb.ToString().Reverse());
    }
}