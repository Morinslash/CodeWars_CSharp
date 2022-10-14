/*
You love coffee and want to know what beans you can afford to buy it.

The first argument to your search function will be a number which represents your budget.

The second argument will be an array of coffee bean prices.

Your 'search' function should return the stores that sell coffee within your budget.

The search function should return a string of prices for the coffees beans you can afford. The prices in this string are to be sorted in ascending order. 
 */

namespace Kyu_7th_Nunit.FilterCoffee;

public class AcceptanceTests
{
    [Test]
    [TestCase(3, new int[] { 6, 1, 2, 9, 2 }, ExpectedResult = "1,2,2")]
    [TestCase(14, new int[] { 7, 3, 23, 9, 14, 20, 7 }, ExpectedResult = "3,7,7,9,14")]
    [TestCase(0, new int[] { 6, 1, 2, 9, 2 }, ExpectedResult = "")]
    public static string FixedTest(int budget, int[] prices)
    {
        return Kata.Search(budget, prices);
    }
}

public class Kata
{
    public static string Search(int budget, int[] prices) => string.Join(',', prices.Where(x => x <= budget).OrderBy(x => x));
}