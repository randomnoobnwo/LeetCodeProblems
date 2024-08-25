namespace LeetLib;

public class PalindromeNumberNoStrings : PalindromeNumberBase
{
    public override bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;

        var reversed = 0;
        var original = x;

        while (x != 0)
        {
            reversed = reversed * 10 + x % 10;
            x /= 10;
        }

        return original == reversed;
    }

    public override string Name => "NoStrings";
}