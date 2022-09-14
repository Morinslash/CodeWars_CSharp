/*
 It's pretty straightforward. 
 Your goal is to create a function that removes the first and last characters of a string. 
 You're given one parameter, the original string. 
 You don't have to worry with strings with less than two characters.
 */

namespace Kyu_8th_Nunit.RemoveFirstAndLastCharacter;

public class AcceptanceTests
{
    [Test]
    public void Test1()
    {
        StringAssert.AreEqualIgnoringCase("loquen", Kata.Remove_char("eloquent"));
        StringAssert.AreEqualIgnoringCase("ountr", Kata.Remove_char("country"));
        StringAssert.AreEqualIgnoringCase("erso", Kata.Remove_char("person"));
        StringAssert.AreEqualIgnoringCase("lac", Kata.Remove_char("place"));
        StringAssert.AreEqualIgnoringCase("", Kata.Remove_char("ok"));
    }
}

public class Kata
{
    public static string Remove_char(string s)
    {
        return s.Remove(s.Length-1, 1).Remove(0, 1);
    }
}