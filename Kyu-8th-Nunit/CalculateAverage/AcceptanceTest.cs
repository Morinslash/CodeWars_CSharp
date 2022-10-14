namespace Kyu_8th_Nunit.CalculateAverage;

public class AcceptanceTest
{
    [Test]
    public void ExampleTest()
    {
        double[] array = { 17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16 };
        Assert.Multiple(() =>
        {
            Assert.That(AverageSolution.FindAverage(array), Is.EqualTo(200.0 / 13.0));

            // Should return 0 on empty array
            Assert.That(AverageSolution.FindAverage(new double[] { }), Is.EqualTo(0));
        });
    }
}

public class AverageSolution
{
    public static double FindAverage(double[] array) => array.Any() ? array.Average() : 0;
}