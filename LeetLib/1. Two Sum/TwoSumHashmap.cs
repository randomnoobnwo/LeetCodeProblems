namespace LeetLib;

public class TwoSumHashmap : TwoSum1
{
    public override int[] TwoSum(int[] nums, int target)
    {
        if (nums.Length == 2)
            return new [] { 0, 1 };
        
        var dict = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            dict[nums[i]] = i;
        }
        
        for (var i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            if (dict.TryGetValue(complement, out var value) && value != i)
                return new [] { i, value };
        }
        
        throw new Exception("No solution while exactly one expected");
    }

    public override string Name => "Hashmap";
}