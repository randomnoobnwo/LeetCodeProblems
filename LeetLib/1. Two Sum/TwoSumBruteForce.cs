namespace LeetLib;

public class TwoSumBruteForce : TwoSum1
{
    public override int[] TwoSum(int[] nums, int target)
    {
        if (nums.Length == 2)
            return new [] { 0, 1 };
        
        for (var currentIdx = 0; currentIdx < nums.Length - 1; currentIdx++)
        {
            for (var i = currentIdx + 1; i < nums.Length; i++)
            {
                if (nums[currentIdx] + nums[i] == target)
                    return new [] { currentIdx, i };
            }
        }
        
        throw new Exception("No solution while exactly one expected");
    }

    public override string Name => "Brute Force";
}