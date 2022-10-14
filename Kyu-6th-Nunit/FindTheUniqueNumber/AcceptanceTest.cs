/*
 * There is an array with some numbers. All numbers are equal except for one. Try to find it!

findUniq([ 1, 1, 1, 2, 1, 1 ]) === 2
findUniq([ 0, 0, 0.55, 0, 0 ]) === 0.55
It’s guaranteed that array contains at least 3 numbers.

The tests contain some very huge arrays, so think about performance.
 */

namespace Kyu_6th_Nunit.FindTheUniqueNumber;

public class AcceptanceTest
{
    [TestCase(new[] { 1, 2, 2, 2 }, ExpectedResult = 1)]
    [TestCase(new[] { -2, 2, 2, 2 }, ExpectedResult = -2)]
    [TestCase(new[] { 11, 11, 14, 11, 11 }, ExpectedResult = 14)]
    public int BaseTest(IEnumerable<int> numbers)
    {
        return Kata.GetUnique(numbers);
    }
}

public class Kata
{
    public static int GetUnique(IEnumerable<int> numbers) => numbers.First(number => numbers.Count(item => item == number) == 1);
}