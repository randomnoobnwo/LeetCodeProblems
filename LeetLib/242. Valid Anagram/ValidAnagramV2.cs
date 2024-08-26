namespace LeetLib;

public class ValidAnagramV2 : ValidAnagramBase
{
    public override bool ValidAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        if (s.Equals(t))
            return true;

        var charCounts = new int[26];

        for (var i = 0; i < s.Length; i++)
        {
            charCounts[s[i] - 'a']++;
            charCounts[t[i] - 'a']--;
        }

        for (var i = 0; i < 26; i++)
        {
            if (charCounts[i] != 0)
                return false;
        }

        return true;
    }

    public override string Name => "V2";
}