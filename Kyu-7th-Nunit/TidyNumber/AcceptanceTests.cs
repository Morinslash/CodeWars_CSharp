/*
Definition
A Tidy number is a number whose digits are in non-decreasing order.
Task
Given a number, Find if it is Tidy or not .
Notes
Number passed is always Positive .
Return the result as a Boolean

tidyNumber (12) ==> return (true)
tidyNumber (32) ==> return (false)
 */

namespace Kyu_7th_Nunit.TidyNumber;

public class AcceptanceTests
{
    [TestCase(12)]
    [TestCase(2789)]
    [TestCase(2335)]
    public void BasicTestsTrue(int n)
    {
        Assert.IsTrue(Kata.TidyNumber(n));
    }

    [TestCase(102)]
    [TestCase(9672)]
    public void BasicTestsFalse(int n)
    {
        Assert.IsFalse(Kata.TidyNumber(n));
    }
}

public class Kata
{
    public static bool TidyNumber(int n) => $"{n}" == string.Concat($"{n}".OrderBy(c => c));
    // {
    //     // var digits = new List<int>();
    //     // for (; n != 0; n /= 10)
    //     // {
    //     //     digits.Add(n % 10);
    //     // }
    //     // digits.Reverse();
    //     // if (digits.Count <= 1) return true;
    //     // for (int i = 1; i < digits.Count; i++)
    //     // {
    //     //     if (digits[i] < digits[i - 1])
    //     //     {
    //     //         return false;
    //     //     }
    //     // }
    //     // return true;
    // }
}