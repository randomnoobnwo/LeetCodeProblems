namespace LeetLib;

public class ValidAnagramV3 : ValidAnagramBase
{
    public override bool ValidAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        if (s.Equals(t))
            return true;
        
        long sHash = ComputeAnagramHash(s);
        long tHash = ComputeAnagramHash(t);

        return sHash == tHash;
    }
    
    int ComputeAnagramHash(string s)
    {
        const int MOD = 1_000_000_007;  // A large prime number
        var BASE = 31;  // A base for polynomial rolling hash
    
        var charCounts = new int[26];  // Assuming only lowercase 'a'-'z'
    
        // Count the frequency of each character in the string
        for (var i = 0; i < s.Length; i++)
        {
            charCounts[s[i] - 'a']++;
        }
    
        int hash = 0;
    
        // Compute the hash using the frequency array
        for (int i = 0; i < 26; i++)
        {
            hash = (hash + charCounts[i] * BASE) % MOD;
            BASE = (BASE * 31) % MOD;  // Update BASE with a modulus to keep numbers small
        }
    
        return hash;
    }

    public override string Name => "V3";
}