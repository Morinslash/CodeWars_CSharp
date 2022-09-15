/*
Below we will define what and n-interesting polygon is and your task is to find its area for a given n.
A 1-interesting polygon is just a square with a side of length 1. 
An n-interesting polygon is obtained by taking the n - 1-interesting polygon and appending 
1-interesting polygons to its rim side by side. 
You can see the 1-, 2- and 3-interesting polygons in the picture below.
 */

namespace Kyu_7th_Nunit.SimpleFunction63ShapeArea;

public class AcceptanceTests
{
    [Test]
    public void BasicTests()
    {
        var kata = new Kata();

        Assert.AreEqual(5, kata.ShapeArea(2));

        Assert.AreEqual(13, kata.ShapeArea(3));

        Assert.AreEqual(1, kata.ShapeArea(1));

        Assert.AreEqual(41, kata.ShapeArea(5));
    }
}

public class Kata
{
    public int ShapeArea(int n)
        => (int)(Math.Pow(n, 2) + Math.Pow(n-1, 2));
}