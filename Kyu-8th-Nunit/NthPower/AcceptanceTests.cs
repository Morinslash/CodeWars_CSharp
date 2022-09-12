/*
You are given an array with positive numbers and a non-negative number N. 
You should find the N-th power of the element in the array with the index N. 
If N is outside of the array, then return -1. 
Don't forget that the first element has the index 0.

Let's look at a few examples:

array = [1, 2, 3, 4] and N = 2, then the result is 3^2 == 9;
array = [1, 2, 3] and N = 3, but N is outside of the array, so the result is -1.
 */

namespace Kyu_8th_Nunit.NthPower;

public class AcceptanceTests
{
    [Test]
    public void SampleTest()
    {
        Assert.That(Kata.Index(new int[] { 1, 2, 3, 4 }, 2), Is.EqualTo(9));
        Assert.That(Kata.Index(new int[] { 1, 3, 10, 100 }, 3), Is.EqualTo(1000000));
    }
}

public class Kata
{
    public static double Index(int[] array, int n)
    {
        return array.Length <= n ? -1 : Math.Pow(array[n], n);
    }
}