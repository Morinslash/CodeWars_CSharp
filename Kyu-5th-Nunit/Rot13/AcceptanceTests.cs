/*
ROT13 is a simple letter substitution cipher that replaces a letter with the letter 13 letters after it in the alphabet.
ROT13 is an example of the Caesar cipher.

Create a function that takes a string and returns the string ciphered with Rot13. 
If there are numbers or special characters included in the string, they should be returned as they are. 
Only letters from the latin/english alphabet should be shifted, like in the original Rot13 "implementation".
 */

using System.Diagnostics;
using System.Text;

namespace Kyu_5th_Nunit.Rot13;

public class AcceptanceTests
{
    [Test, Description("test")]
    public void testTest()
    {
        Assert.That(Kata.Rot13("test"), Is.EqualTo("grfg"),
            $"Input: test, Expected Output: grfg, Actual Output: {Kata.Rot13("test")}");
    }

    [Test, Description("Test")]
    public void TestTest()
    {
        Assert.That(Kata.Rot13("Test"), Is.EqualTo("Grfg"),
            $"Input: Test, Expected Output: Grfg, Actual Output: {Kata.Rot13("Test")}");
    }

    [Test, Description("Test")]
    public void TestTestWithNumberAndSpecial()
    {
        Assert.That(Kata.Rot13("Test1!"), Is.EqualTo("Grfg1!"),
            $"Input: Test1!, Expected Output: Grfg1!, Actual Output: {Kata.Rot13("Test")}");
    }
}

public class Kata
{
    private const int AlphabetLength = 26;
    private static readonly List<int> LowerCase = Enumerable.Range('a', AlphabetLength).ToList();
    private static readonly List<int> UpperCase = Enumerable.Range('A', AlphabetLength).ToList();

    public static string Rot13(string message)
    {
        return string.Join(string.Empty, message.Select(c => char.IsLetter(c) ? CalculateRot13CharValue(c) : c).ToArray());
    }
    
    private static char CalculateRot13CharValue(char c)
    {
        return char.IsUpper(c)
            ? Convert.ToChar(UpperCase[(UpperCase.IndexOf(c) + 13) % UpperCase.Count])
            : Convert.ToChar(LowerCase[(LowerCase.IndexOf(c) + 13) % LowerCase.Count]);
    }
}