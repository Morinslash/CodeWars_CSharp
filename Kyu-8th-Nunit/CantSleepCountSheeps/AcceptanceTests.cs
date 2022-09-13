/*
 *Given a non-negative integer, 3 for example, return a string with a murmur: "1 sheep...2 sheep...3 sheep...".
 * Input will always be valid, i.e. no negative integers.
 */

using System.Text;

namespace Kyu_8th_Nunit.CantSleepCountSheeps;

public class AcceptanceTests
{
    [Test, Description("Example Tests")]
    public void ExampleTests()
    {
        Assert.That(Kata.CountSheep(0), Is.EqualTo(""));
        Assert.That(Kata.CountSheep(1), Is.EqualTo("1 sheep..."));
        Assert.That(Kata.CountSheep(2), Is.EqualTo("1 sheep...2 sheep..."));
        Assert.That(Kata.CountSheep(3), Is.EqualTo("1 sheep...2 sheep...3 sheep..."));
    }
}

public static class Kata
{
    public static string CountSheep(int n)
    {
        return string.Concat(Enumerable.Range(1, n).Select(i => $"{i} sheep..."));
        // StringBuilder output = new StringBuilder();
        // for (int i = 1; i <= n; i++)
        // {
        //     output.Append($"{i} sheep...");
        // }
        //
        // return output.ToString();
    }
}