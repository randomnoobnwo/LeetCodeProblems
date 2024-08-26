namespace LeetLib;

public class ValidAnagramV1 : ValidAnagramBase
{
    public override bool ValidAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        if (s.Equals(t))
            return true;
        
        var sChars = s.ToCharArray();
        var tChars = t.ToCharArray();

        var sHash = new Dictionary<char, int>();

        for (var i = 0; i < sChars.Length; i++)
        {
            var c = sChars[i];
            if (sHash.TryAdd(c, 1))
                continue;

            sHash[c]++;
        }

        for (var j = 0; j < tChars.Length; j++)
        {
            var c = tChars[j];
            if (!sHash.ContainsKey(c))
                return false;

            sHash[c]--;
            if (sHash[c] <= 0)
                sHash.Remove(c);
        }

        return sHash.Count <= 0;
    }

    public override string Name => "V1";
}