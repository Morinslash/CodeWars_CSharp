/*
 The goal of this exercise is to convert a string to a new string where each character in the new string is 
 "(" if that character appears only once in the original string, or ")" if that character appears more than once in the original string. 
 Ignore capitalization when determining if a character is a duplicate.
 
"din"      =>  "((("
"recede"   =>  "()()()"
"Success"  =>  ")())())"
"(( @"     =>  "))((" 
 */

namespace Kyu_6th_Nunit.DuplicateEncoder;

public class AcceptanceTests
{
    [Test]
    public void BasicTests()
    {
        Assert.Multiple(() =>
        {
            Assert.That(Kata.DuplicateEncode("din"), Is.EqualTo("((("));
            Assert.That(Kata.DuplicateEncode("recede"), Is.EqualTo("()()()"));
            Assert.That(Kata.DuplicateEncode("Success"), Is.EqualTo(")())())"), "should ignore case");
            Assert.That(Kata.DuplicateEncode("(( @"), Is.EqualTo("))(("));
        });
    }
}

public class Kata
{
    public static string DuplicateEncode(string word) 
        => string.Concat(word.ToLower().Select( c => word.ToLower().Count(w => w == c) > 1 ? ')' : '('));
}