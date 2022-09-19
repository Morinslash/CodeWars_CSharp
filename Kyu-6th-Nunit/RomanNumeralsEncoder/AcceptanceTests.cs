/*
Create a function taking a positive integer as its parameter and returning a string containing the Roman Numeral representation of that integer.
Modern Roman numerals are written by expressing each digit separately starting with the left most digit and skipping any digit with a value of zero. 
In Roman numerals 1990 is rendered: 1000=M, 900=CM, 90=XC; resulting in MCMXC. 2008 is written as 2000=MM, 8=VIII; or MMVIII. 1666 uses each Roman symbol in descending order: MDCLXVI.

Example:
RomanConvert.Solution(1000) -- should return "M"
 */

using System.Text;

namespace Kyu_6th_Nunit.RomanNumeralsEncoder;

public class AcceptanceTests
{
    [TestCase(1, "I")]
    [TestCase(2, "II")]
    [TestCase(4, "IV")]
    [TestCase(500, "D")]
    [TestCase(1000, "M")]
    [TestCase(1954, "MCMLIV")]
    [TestCase(1990, "MCMXC")]
    [TestCase(2008, "MMVIII")]
    [TestCase(2014, "MMXIV")]
    public void Test(int value, string expected)
    {
        Assert.That(RomanConvert.Solution(value), Is.EqualTo(expected));
    }
}

public class RomanConvert
{
    private static Dictionary<int, string> mapper = new()
    {
        { 1, "I" },
        { 4, "IV" },
        { 5, "V" },
        { 9, "IX" },
        { 10, "X" },
        { 40, "XL" },
        { 50, "L" },
        { 90, "XC" },
        { 100, "C" },
        { 400, "CD" },
        { 500, "D" },
        { 900, "CM" },
        { 1000, "M" },
    };

    public static string Solution(int n)
    {
        var romanNumber = new StringBuilder();
        while (n > 0)
        {
            var value = mapper.Keys.Where(x => x <= n).Max();
            romanNumber.Append(mapper.GetValueOrDefault(value));
            n -= value;
        }
        return romanNumber.ToString();
    }
}