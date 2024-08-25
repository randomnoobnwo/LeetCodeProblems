namespace LeetLib;

public class PalindromeNumberCheckString : PalindromeNumberBase
{
    public override bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;

        var str = x.ToString();

        for (var i = 0; i < str.Length; i++)
        {
            if (str[i] != str[str.Length - 1 - i])
                return false;
        }

        return true;
    }

    public override string Name => "Check string by char";
}