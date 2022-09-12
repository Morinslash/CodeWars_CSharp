/*
You can print your name on a billboard ad. Find out how much it will cost you. 
Each character has a default price of £30, but that can be different if you are given 2 parameters instead of 1.

You can not use multiplier "*" operator.

If your name would be Jeong-Ho Aristotelis, ad would cost £600. 20 leters * 30 = 600 (Space counts as a character).
 */
namespace Kyu_8th_Nunit.NameOnBillboard;

public class AcceptanceTests
{
    [Test]
    public void SampleTests()
    {
        Assertion(600, "Jeong-Ho Aristotelis");
        Assertion(40, "CODEWARS", 5);
    }

    private static void Assertion(double expected, string name, double price = -1) =>
        Assert.That(
            price == -1 ? Kata.Billboard(name) : Kata.Billboard(name, price), Is.EqualTo(expected).Within(0.000001),
            $"\n  Name: \"{name}\"\n" +
            $"  Price: {(price == -1 ? 30 : price)}\n\n"
        );
}

public class Kata
{
    

    public static double Billboard(string name, double price = 30)
    {
        return name.Sum(_ => price);
        // double toPay = 0;
        // for (int i = 0; i < name.Length; i++)
        // {
        //     toPay += price;
        // }
        //
        // return toPay;
    }
}