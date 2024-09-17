namespace LeetLib;

public class TargetSumV1 : TargetSumBase
{
    public override int TargetSum(int[] nums, int target)
    {
        var dict = new Dictionary<(int,int), int>();

        return Helper(0, 0);

        int Helper(int index, int total)
        {
            if (index == nums.Length)
                return total == target ? 1 : 0;
            
            if (dict.ContainsKey((index, total)))
                return dict[(index, total)];
            
            var add = Helper(index + 1, total + nums[index]);
            var sub = Helper(index + 1, total - nums[index]);
            
            dict[(index, total)] = add + sub;
            
            return dict[(index, total)];
        }
    }
    
    public override string Name => "V1";
}