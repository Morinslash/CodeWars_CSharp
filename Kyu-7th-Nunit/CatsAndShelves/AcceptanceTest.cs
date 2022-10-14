/*
 An infinite number of shelves are arranged one above the other in a staggered fashion.
The cat can jump up to 3 shelves at the same time: from shelf 1 to shelf 2 or 4 (the cat cannot climb on the shelf directly above its head), according to the illustration:

                 ┌────────┐
                 │-6------│
                 └────────┘
┌────────┐       
│------5-│        
└────────┘  ┌─────► OK!
            │    ┌────────┐
            │    │-4------│
            │    └────────┘
┌────────┐  │
│------3-│  │     
BANG!────┘  ├─────► OK! 
  ▲  |\_/|  │    ┌────────┐
  │ ("^-^)  │    │-2------│
  │ )   (   │    └────────┘
┌─┴─┴───┴┬──┘
│------1-│
└────────┘
Input
Start and finish shelf numbers (always positive integers, finish no smaller than start)

Task
Find the minimum number of jumps to go from start to finish

Example
Start 1, finish 5, then answer is 2 (1 => 4 => 5 or 1 => 2 => 5)
 */

namespace Kyu_7th_Nunit.CatsAndShelves;

public class AcceptanceTest
{
    private static void Testing(int actual, int expected)
    {
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public static void Mew()
    {
        Testing(Kata.Cats(1, 5), 2);
    }

    [Test]
    public static void OneMoreMew()
    {
        Testing(Kata.Cats(2, 5), 1);
    }

    [Test]
    public static void OneMoreMewMew()
    {
        Testing(Kata.Cats(1, 3), 2);
    }
}

public class Kata
{
    public static int Cats(int start, int finish)
    {
        var diff = finish - start;
        return diff / 3 + diff % 3;
    }
}