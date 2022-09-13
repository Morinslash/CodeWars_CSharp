/*
 * Sounds easy right? Just bear in mind that you can't use any of the following characters: 0123456789*+-/
Good luck :)
 */

using NUnit.Framework.Constraints;

namespace Kyu_8th_Nunit._5WithoutNumber;

public class AcceptanceTests
{
    [Test]
    public void Test()
    {
        Assert.That(Kata.UnusualFive(), Is.EqualTo(5));
    }
}

public static class Kata
{
    public static int UnusualFive()
    {
        return "Five!".Length;
    }
}