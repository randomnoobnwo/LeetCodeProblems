namespace LeetLib;

public class MergeSortV1 : SortAnArrayBase
{
    public override int[] SortAnArray(int[] nums)
    { 
        MergeSort(nums);

        return nums;
    }
    
    private void MergeSort(int[] nums)
    {
        if (nums.Length <= 1)
            return;
        
        var mid = nums.Length / 2;
        var left = new int[mid];
        var right = new int[nums.Length - mid];
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (i < mid)
                left[i] = nums[i];
            else
                right[i - mid] = nums[i];
        }
        
        MergeSort(left);
        MergeSort(right);
        
        Merge(nums, left, right);
    }

    private void Merge(int[] nums, int[] left, int[] right)
    {
        var i = 0;
        var j = 0;
        var k = 0;
        
        while (i < left.Length && j < right.Length)
        {
            if (left[i] < right[j])
                nums[k++] = left[i++];
            else
                nums[k++] = right[j++];
        }
        
        while (i < left.Length)
            nums[k++] = left[i++];
        
        while (j < right.Length)
            nums[k++] = right[j++];
    }

    private void Swap(int[] nums, int p1, int p2)
    {
        var temp = nums[p1];
        nums[p1] = nums[p2];
        nums[p2] = temp;
    }

    public override string Name => "MergeSortV1";
}