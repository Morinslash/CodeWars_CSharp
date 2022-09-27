/*
 The hamming distance of two equal-length strings is the number of positions, in which the two string differ. 
 In other words, the number of character substitutions required to transform one string into the other.

For this first Kata, you will write a function hamming_distance(a, b) with two equal-length strings containing only 0s and 1s as parameters. 
There is no need to test the parameters for validity (but you can, if you want).
The function's output should be the hamming distance of the two strings as an integer.

Example:

Kata.HammingDistance("100101', "101001") == 2
Kata.HammingDistance("1010', "0101") == 4
 */

namespace Kyu_7th_Nunit.HammingDistance;

public class AcceptanceTests
{
    [Test, Description("Sample Tests")]
    public void SampleTest()
    {
        Assert.Multiple(() =>
        {
            Assert.That(Kata.HammingDistance("100101", "101001"), Is.EqualTo(2));
            Assert.That(Kata.HammingDistance("1010", "0101"), Is.EqualTo(4));
            Assert.That(Kata.HammingDistance("100101011011010010010", "101100010110010110101"), Is.EqualTo(9));
        });
    }
}

public class Kata
{
    public static int HammingDistance(string a, string b) => a.Where((t, i) => t != b[i]).Count();
}