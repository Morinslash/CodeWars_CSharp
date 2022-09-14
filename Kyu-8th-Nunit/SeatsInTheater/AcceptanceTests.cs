/*
Your friend advised you to see a new performance in the most popular theater in the city.
He knows a lot about art and his advice is usually good, but not this time:
the performance turned out to be awfully dull. It's so bad you want to sneak out, which is quite simple,
especially since the exit is located right behind your row to the left.
All you need to do is climb over your seat and make your way to the exit.
The main problem is your shyness: you're afraid that you'll end up blocking the view 
(even if only for a couple of seconds) of all the people who sit behind you and in your column or 
the columns to your left. To gain some courage, you decide to calculate the number of such people 
and see if you can possibly make it to the exit without disturbing too many people.

Given the total number of rows and columns in the theater (nRows and nCols, respectively), 
and the row and column you're sitting in, return the number of people who sit strictly behind you 
and in your column or to the left, assuming all seats are occupied.

Example
For nCols = 16, nRows = 11, col = 5 and row = 3, the output should be

Kata.SeatsInTheater(nCols, nRows, col, row); // --> 96
 */

namespace Kyu_8th_Nunit.SeatsInTheater;

public class AcceptanceTests
{
    [Test]
    public void ExampleTests()
    {
        Assert.That(Kata.SeatsInTheater(16, 11, 5, 3), Is.EqualTo(96));

        Assert.That(Kata.SeatsInTheater(1, 1, 1, 1), Is.EqualTo(0));

        Assert.That(Kata.SeatsInTheater(13, 6, 8, 3), Is.EqualTo(18));

        Assert.That(Kata.SeatsInTheater(60, 100, 60, 1), Is.EqualTo(99));

        Assert.That(Kata.SeatsInTheater(1000, 1000, 1000, 1000), Is.EqualTo(0));
    }
}

public class Kata
{
    public static int SeatsInTheater(int nCols, int nRows, int col, int row)
    {
        int leftCols = nCols - (col - 1);
        int leftRows = nRows - (row);
        return leftRows * leftCols;
    }
}