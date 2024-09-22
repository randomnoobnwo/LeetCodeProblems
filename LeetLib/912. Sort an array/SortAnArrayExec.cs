namespace LeetLib;

public class SortAnArrayExec : LeetBase
{
    public override void Execute()
    {
        base.Execute();
        foreach (var testCase in Cases)
        {
            CheckCase(testCase, new SortAnArrayBase[] { new QuickSortV1(), new MergeSortV1(), new QuickSortV2() });
        }
    }

    protected override string Name => "912. Sort an array";
    
    private void CheckCase(SortAnArrayCase testCase, SortAnArrayBase[] algorithms)
    {
        Console.WriteLine($"Case: {testCase.Description} | Nums: {string.Join(", ", testCase.Nums)} | Expected: {string.Join(", ", testCase.Expected)}");
        
        foreach (var algorithm in algorithms)
        {
            // measure execution time
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var result = algorithm.SortAnArray(testCase.Nums);
            watch.Stop();
            Console.WriteLine($"{algorithm.Name}: {(Compare(result, testCase.Expected) ? "Test Passed" : "Test Failed")} in {watch.ElapsedTicks}ticks (result: {string.Join(", ", result)})");
        }
    }
    
    private bool Compare(int[] result, int[] expected)
    {
        if (result.Length != expected.Length)
            return false;
        
        for (var i = 0; i < result.Length; i++)
        {
            if (result[i] != expected[i])
                return false;
        }
        
        return true;
    }
    
    private SortAnArrayCase[] Cases =>
    [
        new()
        {
            Nums = [5, 2, 3, 1],
            Expected = [1, 2, 3, 5]
        },
        new()
        {
            Nums = [5, 1, 1, 2, 0, 0],
            Expected = [0, 0, 1, 1, 2, 5]
        },
        new()
        {
            Nums = [-4,0,7,4,9,-5,-1,0,-7,-1],
            Expected = [-7,-5,-4,-1,-1,0,0,4,7,9]
        }
    ];
}

public class SortAnArrayCase : TestCase
{
    public int[] Nums { get; set; }
    public int[] Expected { get; set; }
    public override string Description { get; }
}