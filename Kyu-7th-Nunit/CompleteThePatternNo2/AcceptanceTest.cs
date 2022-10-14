/*
You have to write a function pattern which returns the following Pattern (See Pattern & Examples) upto n number of rows.

Note: Returning the pattern is not the same as Printing the pattern.
Rules/Note:
If n < 1 then it should return "" i.e. empty string.
There are no whitespaces in the pattern.

Examples:
pattern(4):

4321
432
43
4
pattern(11):

1110987654321
111098765432
11109876543
1110987654
111098765
11109876
1110987
111098
11109
1110
11
Hint: Use \n in string to jump to next line
 */

using System.Text;

namespace Kyu_7th_Nunit.CompleteThePatternNo2;

public class AcceptanceTest
{
    private readonly Kata _k = new Kata();
    [Test]
    public void SimpleNumbers()
    {
        Assert.Multiple(() =>
        {
            Assert.That(_k.Pattern(1), Is.EqualTo("1"));
            Assert.That(_k.Pattern(2), Is.EqualTo("21\n2"));
            Assert.That(_k.Pattern(5), Is.EqualTo("54321\n5432\n543\n54\n5"));
        });
    }
}

internal class Kata
{
    public string Pattern(int n)
    {
        if (n <= 0) return string.Empty;

        return string.Join("\n", Enumerable
            .Range(1, n)
            .Select(x =>
                string.Concat(Enumerable
                    .Range(x, n - x + 1)
                    .Reverse()
                    .Select(y => y.ToString()))));
        // if(n < 1){
        //     return "";
        // }
        // var enumerable = Enumerable.Range(1,n).Reverse().ToList();
        // var result = new List<string>();
        // while (enumerable.Count > 0)
        // {
        //     var temp = string.Join(string.Empty,enumerable);
        //     result.Add(temp);
        //     enumerable.Remove(enumerable.Last());
        // }
        // return  string.Join("\n", result);
    }
       
}