/*
 The museum of incredible dull things
The museum of incredible dull things wants to get rid of some exhibitions. 
Miriam, the interior architect, comes up with a plan to remove the most boring exhibitions. 
She gives them a rating, and then removes the one with the lowest rating.

However, just as she finished rating all exhibitions, she's off to an important fair, 
so she asks you to write a program that tells her the ratings of the items after one removed the lowest one. Fair enough.

Task
Given an array of integers, remove the smallest value. Do not mutate the original array/list. 
If there are multiple elements with the same value, remove the one with a lower index. 
If you get an empty array/list, return an empty array/list.

Don't change the order of the elements that are left.

Examples
* Input: [1,2,3,4,5], output= [2,3,4,5]
* Input: [5,3,2,1,4], output = [5,3,2,4]
* Input: [2,2,1,2,1], output = [2,2,2,1]
 */

namespace Kyu_7th_Nunit.RemoveTheMinimum;

public class AcceptanceTest
{
    private static void Tester(List<int> argument, List<int> expectedResult)
    {
        CollectionAssert.AreEqual(expectedResult, Remover.RemoveSmallest(argument));
    }

    [Test]
    public static void BasicTests()
    {
        Tester(new List<int> { 1, 2, 3, 4, 5 }, new List<int> { 2, 3, 4, 5 });
        Tester(new List<int> { 5, 3, 2, 1, 4 }, new List<int> { 5, 3, 2, 4 });
        Tester(new List<int> { 1, 2, 3, 1, 1 }, new List<int> { 2, 3, 1, 1 });
        Tester(new List<int>(), new List<int>());
    }
}

internal class Remover
{
    public static List<int> RemoveSmallest(List<int> numbers)
    {
        if (!numbers.Any())
        {
            return numbers;
        }
        var copyNumbers = numbers.Select(i => i).ToList();
        copyNumbers.Remove(copyNumbers.First(x => x == copyNumbers.Min()));
        return copyNumbers;
    }
}