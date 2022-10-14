/*
 Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits that occur more than once in the input string. 
 The input string can be assumed to contain only alphabets (both uppercase and lowercase) and numeric digits.

Example
"abcde" -> 0 # no characters repeats more than once
"aabbcde" -> 2 # 'a' and 'b'
"aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
"indivisibility" -> 1 # 'i' occurs six times
"Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
"aA11" -> 2 # 'a' and '1'
"ABBA" -> 2 # 'A' and 'B' each occur twice

 */

namespace Kyu_6th_Nunit.CountingDuplicates;

public class AcceptanceTest
{
    [Test]
    public void KataTests()
    {
        Assert.Multiple(() =>
        {
            Assert.That(Kata.DuplicateCount(""), Is.EqualTo(0));
            Assert.That(Kata.DuplicateCount("abcde"), Is.EqualTo(0));
            Assert.That(Kata.DuplicateCount("aabbcde"), Is.EqualTo(2));
            Assert.That(Kata.DuplicateCount("aabBcde"), Is.EqualTo(2), "should ignore case");
            Assert.That(Kata.DuplicateCount("Indivisibility"), Is.EqualTo(1));
            Assert.That(Kata.DuplicateCount("Indivisibilities"), Is.EqualTo(2), "characters may not be adjacent");
        });
    }
}

public class Kata
{
    public static int DuplicateCount(string str) =>
        str.ToLowerInvariant()
            .GroupBy(x => x)
            .Count(g => g.Count() > 1);
}