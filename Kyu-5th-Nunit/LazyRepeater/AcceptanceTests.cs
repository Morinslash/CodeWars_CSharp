/*
 The makeLooper() function (make_looper in Python) takes a string (of non-zero length) as an argument. 
 It returns a function. The function it returns will return successive characters of the string on successive invocations. 
 It will start back at the beginning of the string once it reaches the end.

For example:

var abc = makeLooper('abc');
abc(); // should return 'a' on this first call
abc(); // should return 'b' on this second call
abc(); // should return 'c' on this third call
abc(); // should return 'a' again on this fourth call
Func<char> abc = Kata.MakeLooper("abc");
abc(); // should return 'a' on this first call
abc(); // should return 'b' on this second call
abc(); // should return 'c' on this third call
abc(); // should return 'a' again on this fourth call
 */

namespace Kyu_5th_Nunit.LazyRepeater;

public class AcceptanceTests
{
    [Test]
    public void SampleTest()
    {
        Func<char> abc = Kata.MakeLooper("abc");
        // Two iterations of looper
        // 1
        Assert.That(abc(), Is.EqualTo('a'));
        Assert.That(abc(), Is.EqualTo('b'));
        Assert.That(abc(), Is.EqualTo('c'));
        // 2
        Assert.That(abc(), Is.EqualTo('a'));
        Assert.That(abc(), Is.EqualTo('b'));
        Assert.That(abc(), Is.EqualTo('c'));
    }
}

public class Kata
{
    private static int _invocation;
    public static Func<char> MakeLooper(string str) => () => str[_invocation++ % str.Length];
}