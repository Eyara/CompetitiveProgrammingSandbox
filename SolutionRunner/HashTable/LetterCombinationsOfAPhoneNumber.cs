using SolutionRunner.Base;

namespace SolutionRunner.HashTable;

/// <summary>
///     https://leetcode.com/problems/letter-combinations-of-a-phone-number
/// </summary>
public class LetterCombinationsOfAPhoneNumber : BaseSolution
{
    public override void Solve()
    {
        var input = Console.ReadLine();

        Console.WriteLine(LetterCombinations(input));
    }

    public IList<string> LetterCombinations(string digits)
    {
        var romanToIntDict = new Dictionary<string, string>
        {
            { "2", "abc" },
            { "3", "def" },
            { "4", "ghi" },
            { "5", "jkl" },
            { "6", "mno" },
            { "7", "pqrs" },
            { "8", "tuv" },
            { "9", "wxyz" }
        };

        var result = new List<string>();

        if (digits.Length == 0) return result;

        var n = digits.Length;
        var i = 1;

        var charDigits = new List<List<string>>();

        for (var j = 0; j < n; j++)
        {
            var tmpString = romanToIntDict[digits[j].ToString()];
            var tmpList = new List<string>();
            for (var k = 0; k < tmpString.Length; k++) tmpList.Add(tmpString[k].ToString());
            charDigits.Add(tmpList);
        }

        result.AddRange(charDigits[0]);

        while (i < n)
        {
            var tmpResult = new string[result.Count];
            result.CopyTo(tmpResult);
            result.Clear();
            for (var j = 0; j < tmpResult.Length; j++)
            {
                var currentDigitsList = romanToIntDict[digits[i].ToString()];
                for (var k = 0; k < currentDigitsList.Length; k++) result.Add(tmpResult[j] + currentDigitsList[k]);
            }

            i++;
        }

        return result;
    }
}