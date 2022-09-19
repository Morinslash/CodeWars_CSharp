/*
You have to write a function pattern which returns the following Pattern(See Pattern & Examples) upto n number of rows.
Note:Returning the pattern is not the same as Printing the pattern.
Rules/Note:
If n < 1 then it should return "" i.e. empty string.
There are no whitespaces in the pattern.
Example:
pattern(5):

1
22
333
4444
55555
 */

namespace Kyu_7th_Nunit.CompleteThePattern1;

public class AcceptanceTests
{
    Kata k = new Kata();

    [Test]
    public void SimpleNumbers()
    {
        Assert.That(k.Pattern(1), Is.EqualTo("1"));
        Assert.That(k.Pattern(2), Is.EqualTo("1\n22"));
        Assert.That(k.Pattern(5), Is.EqualTo("1\n22\n333\n4444\n55555"));
    }
}

public class Kata
{
    public string Pattern(int n)
        => string.Join("\n", Enumerable.Repeat(new string('+', n), n));
}