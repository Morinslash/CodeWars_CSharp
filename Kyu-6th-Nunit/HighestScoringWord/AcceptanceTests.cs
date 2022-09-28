/*
Given a string of words, you need to find the highest scoring word.

Each letter of a word scores points according to its position in the alphabet: a = 1, b = 2, c = 3 etc.

You need to return the highest scoring word as a string.

If two words score the same, return the word that appears earliest in the original string.

All letters will be lowercase and all inputs will be valid.
 */

namespace Kyu_6th_Nunit.HighestScoringWord;

public class AcceptanceTests
{
    private static IEnumerable<TestCaseData> testCases
    {
        get
        {
            yield return new TestCaseData("man i need a taxi up to ubud").Returns("taxi");
            yield return new TestCaseData("what time are we climbing up to the volcano").Returns("volcano");
            yield return new TestCaseData("take me to semynak").Returns("semynak");
            yield return new TestCaseData("aa b").Returns("aa");
            yield return new TestCaseData("b aa").Returns("b");
            yield return new TestCaseData("bb d").Returns("bb");
            yield return new TestCaseData("d bb").Returns("d");
            yield return new TestCaseData("aaa b").Returns("aaa");
        }
    }

    [Test, TestCaseSource("testCases")]
    public string Test(string s) => Kata.High(s);
}

public class Kata
{
    public static string High(string s)
        // => s.Split(' ').OrderByDescending(x => x.Sum(z => z - 'a' + 1)).First();
        => s.Split(' ')
            .GroupBy(str => str.Sum(c => c - 'a' + 1))
            .MaxBy(g => g.Key)!
            .First();
}