namespace LeetLib;

public class ClimbingStairsExec : LeetBase
{
    public override void Execute()
    {
        base.Execute();
        foreach (var testCase in Cases)
        {
            CheckCase(testCase, new ClimbingStairsBase[] { new ClimbingStairsV1() });
        }
    }

    protected override string Name => "70. Climbing Stairs";
    
    private void CheckCase(ClimbingStairsCase testCase, ClimbingStairsBase[] algorithms)
    {
        Console.WriteLine($"Case: {testCase.Description}");
        
        foreach (var algorithm in algorithms)
        {
            // measure execution time
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var result = algorithm.ClimbingStairs(testCase.N);
            watch.Stop();
            Console.WriteLine($"{algorithm.Name}: {(result == testCase.Expected ? "Test Passed" : "Test Failed")} in {watch.ElapsedTicks}ticks");
        }
    }
    
    private ClimbingStairsCase[] Cases
    {
        get
        {
            return new[]
            {
                new ClimbingStairsCase()
                {
                    N = 2,
                    Expected = 2
                },
                new ClimbingStairsCase()
                {
                    N = 3,
                    Expected = 3
                }
            };
        }
    }
}

public class ClimbingStairsCase : TestCase
{
    public int N { get; set; }
    public int Expected { get; set; }
    public override string Description { get; }
}