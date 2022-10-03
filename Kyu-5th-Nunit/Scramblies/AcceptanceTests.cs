/*
Complete the function scramble(str1, str2) that returns true if a portion of str1 characters can be rearranged to match str2, otherwise returns false.

Notes:

Only lower case letters will be used (a-z). No punctuation or digits will be included.
Performance needs to be considered.
Examples
scramble('rkqodlw', 'world') ==> True
scramble('cedewaraaossoqqyt', 'codewars') ==> True
scramble('katas', 'steak') ==> False
 */

namespace Kyu_5th_Nunit.Scramblies;

public class AcceptanceTests
{
    private static void Testing(bool actual, bool expected)
    {
        Assert.That(actual, Is.EqualTo(expected));
    }
    [Test]
    public static void Test1()
    {
        Testing(Kata.Scramble("rkqodlw", "world"), true);
        Testing(Kata.Scramble("cedewaraaossoqqyt", "codewars"), true);
        Testing(Kata.Scramble("katas", "steak"), false);
        Testing(Kata.Scramble("scriptjavx", "javascript"), false);
        Testing(Kata.Scramble("scriptingjava", "javascript"), true);
        Testing(Kata.Scramble("scriptsjava", "javascripts"), true);
        Testing(Kata.Scramble("javscripts", "javascript"), false);
        Testing(Kata.Scramble("aabbcamaomsccdd", "commas"), true);
        Testing(Kata.Scramble("commas", "commas"), true);
        Testing(Kata.Scramble("sammoc", "commas"), true);
    }
}

public class Kata
{
    public static bool Scramble(string str1, string str2) =>
        str2.All(character => str2.Count(c => c == character) <= str1.Count(c => c == character));
}