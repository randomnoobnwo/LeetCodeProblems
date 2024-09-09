namespace LeetLib;

public class GroupAnagramsV3 : GroupAnagramsBase
{
    public override IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var anagrams = new Dictionary<string, List<string>>();

        foreach (var s in strs)
        {
            var characters = s.ToCharArray();

            // Implementing Bubble Sort
            for (var i = 0; i < characters.Length - 1; i++)
            {
                for (var j = 0; j < characters.Length - 1 - i; j++)
                {
                    if (characters[j] <= characters[j + 1]) continue;
                    // Swap characters[j] and characters[j + 1]
                    var temp = characters[j];
                    characters[j] = characters[j + 1];
                    characters[j + 1] = temp;
                }
            }

            // Convert the sorted array back to a string
            var sortedString = new string(characters);

            if (anagrams.ContainsKey(sortedString))
                anagrams[sortedString].Add(s);
            else 
                anagrams[sortedString] = [s];
        }
        
        return anagrams.Values.Select(x => (IList<string>)x).ToList();
    }

    public override string Name => "V3";
}