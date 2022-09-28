/*
Complete the solution so that it splits the string into pairs of two characters. 
If the string contains an odd number of characters then it should replace the missing second character of the final pair with an underscore ('_').

Examples:

* 'abc' =>  ['ab', 'c_']
* 'abcdef' => ['ab', 'cd', 'ef']
*/

using System.Text.RegularExpressions;

namespace Kyu_6th_Nunit.SplitStrings;

public class AcceptanceTests
{
    [Test]
    public void BasicTests()
    {
        Assert.Multiple(() =>
        {
            Assert.That(SplitString.Solution("abc"), Is.EqualTo(new[] { "ab", "c_" }));
            Assert.That(SplitString.Solution("abcdef"), Is.EqualTo(new[] { "ab", "cd", "ef" }));
        });
    }
}

public class SplitString
{
    public static string[] Solution(string str) =>
        // Regex.Matches(str + "_", @"\w{2}").Select(x => x.Value).ToArray();
        str.Select((character, index) => new { index, character })
            .GroupBy(g => g.index / 2, value => value.character)
            .Select(g => string.Join("", g))
            .Select(s => s.Length != 2 ? s + "_" : s)
            .ToArray();
}