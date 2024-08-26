namespace LeetLib;

public class ContainsDuplicateHashmap : ContainsDuplicateBase
{
    public override bool ContainsDuplicate(int[] nums)
    {
        var set = new HashSet<int>();

        return nums.Any(num => !set.Add(num));
    }

    public override string Name => "Hashmap";
}