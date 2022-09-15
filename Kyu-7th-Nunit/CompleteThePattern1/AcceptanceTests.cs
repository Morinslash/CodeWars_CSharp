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

using System.Text;

namespace Kyu_7th_Nunit.CompleteThePattern1;

public class AcceptanceTests
{
    Kata k = new Kata();

    [Test]
    public void SimpleNumbers()
    {
        Assert.AreEqual("1", k.Pattern(1));
        Assert.AreEqual("1\n22", k.Pattern(2));
        Assert.AreEqual("1\n22\n333\n4444\n55555", k.Pattern(5));
    }
}

public class Kata
{
    public string Pattern(int n)
    {
        if(n<1) return "";
        return string.Join("\n",
            Enumerable
                .Range(1, n)
                .Select(e => string.Concat(Enumerable.Repeat(e, e))));
    }
}