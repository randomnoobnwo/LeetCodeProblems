namespace LeetLib;

public class QuickSortV1 : SortAnArrayBase
{
    public override int[] SortAnArray(int[] nums)
    { 
        QuickSort(nums, 0, nums.Length - 1);

        return nums;
    }
    
    private void QuickSort(int[] nums, int low, int high)
    {
        if (low >= high)
            return;
        
        var pivotIndex = Partition(nums, low, high);

        QuickSort(nums, low, pivotIndex - 1);
        QuickSort(nums, pivotIndex + 1, high);
    }
    
    private int Partition(int[] nums, int low, int high)
    {
        var pivot = nums[high];
        var i = low - 1;
        
        for (var j = low; j < high; j++)
        {
            if (nums[j] <= pivot)
            {
                i++;
                Swap(nums, i, j);
            }
        }
        
        Swap(nums, i + 1, high);
        
        return i + 1;
    }

    private void Swap(int[] nums, int p1, int p2)
    {
        var temp = nums[p1];
        nums[p1] = nums[p2];
        nums[p2] = temp;
    }

    public override string Name => "QuickSortV1";
}