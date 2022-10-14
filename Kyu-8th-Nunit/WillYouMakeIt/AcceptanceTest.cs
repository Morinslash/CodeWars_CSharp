/*
 You were camping with your friends far away from home, but when it's time to go back, you realize that your fuel is running out and the nearest pump is 50 miles away!
 You know that on average, your car runs on about 25 miles per gallon. There are 2 gallons left.

Considering these factors, write a function that tells you if it is possible to get to the pump or not.

Function should return true if it is possible and false if not.
 */

namespace Kyu_8th_Nunit.WillYouMakeIt;

public class AcceptanceTest
{
    [Test]
    public void SampleTest()
    {
        Assert.Multiple(() =>
        {
            Assert.That(Kata.ZeroFuel(50, 25, 2), Is.EqualTo(true));
            Assert.That(Kata.ZeroFuel(100, 50, 1), Is.EqualTo(false));
        });
    }
}

public class Kata
{
    public static bool ZeroFuel(int distanceToPump, int mpg, int fuelLeft) => mpg * fuelLeft >= distanceToPump;
}