/*
 Simple, given a string of words, return the length of the shortest word(s).

String will never be empty and you do not need to account for different data types.
 */

namespace Kyu_7th_Nunit.ShortestWord;

public class AcceptanceTests
{
    [Test]
    public void BasicTests()
    {
        Assert.Multiple(() =>
        {
            Assert.That(Kata.FindShort("bitcoin take over the world maybe who knows perhaps"), Is.EqualTo(3));
            Assert.That(Kata.FindShort("turns out random test cases are easier than writing out basic ones"), Is.EqualTo(3));
            Assert.That(Kata.FindShort("Let's travel abroad shall we"), Is.EqualTo(2));
        });
    }
}

public class Kata
{
    public static int FindShort(string s) => s.Split(' ').OrderBy(w => w.Length).First().Length;
}