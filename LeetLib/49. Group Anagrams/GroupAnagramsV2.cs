namespace LeetLib;

public class GroupAnagramsV2 : GroupAnagramsBase
{
    public override IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var anagrams = new Dictionary<string, List<string>>();

        foreach (var s in strs)
        {
            var characters = s.ToCharArray();
        
            // Sort the characters
            Array.Sort(characters);
        
            // Convert the sorted array back to a string
            var sortedString = new string(characters);
            if (anagrams.ContainsKey(sortedString))
                anagrams[sortedString].Add(s);
            else 
                anagrams[sortedString] = [s];
        }
        
        return anagrams.Values.Select(x => (IList<string>)x).ToList();
    }

    public override string Name => "V2";
}