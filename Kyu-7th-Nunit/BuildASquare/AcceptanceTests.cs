/*
I will give you an integer. Give me back a shape that is as long and wide as the integer. The integer will be a whole number between 1 and 50.
n = 3, so I expect a 3x3 square back just like below as a string:
+++
+++
+++
 */

namespace Kyu_7th_Nunit.BuildASquare;

public class AcceptanceTests
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.GenerateShape(0), Is.EqualTo(""));
        Assert.That(Kata.GenerateShape(1), Is.EqualTo("+"));
        Assert.That(Kata.GenerateShape(2), Is.EqualTo("++\n++"));
        Assert.That(Kata.GenerateShape(3), Is.EqualTo("+++\n+++\n+++"));
    }
}

public class Kata
{
    public static string GenerateShape(int n)
    => n < 1 ? "" :  string.Join("\n",Enumerable
        .Range(1, n)
        .Select(_ => string.Concat(Enumerable.Repeat("+", n))));
}