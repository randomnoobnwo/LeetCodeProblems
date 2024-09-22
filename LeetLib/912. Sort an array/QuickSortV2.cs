namespace LeetLib;

public class QuickSortV2 : SortAnArrayBase
{
    public override int[] SortAnArray(int[] nums)
    { 
        if (nums.Length <= 0)
            return nums;
        
        var pivot = nums[^1];
        
        var left = nums.Where(n => n < pivot).ToArray();
        var right = nums.Where(n => n > pivot).ToArray();
        var mid = nums.Where(n => n == pivot).ToArray();
        
        return SortAnArray(left).Concat(mid).Concat(SortAnArray(right)).ToArray();
    }

    public override string Name => "QuickSortV2";
}