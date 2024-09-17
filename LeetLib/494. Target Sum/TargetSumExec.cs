using LeetLib;

namespace LeetLib;

public class TargetSumExec : LeetBase
{
    public override void Execute()
    {
        base.Execute();
        foreach (var testCase in Cases)
        {
            CheckCase(testCase, new TargetSumBase[] { new TargetSumV1() });
        }
    }

    protected override string Name => "494. Target Sum";
    
    private void CheckCase(TargetSumCase testCase, TargetSumBase[] algorithms)
    {
        Console.WriteLine($"Case: {testCase.Description}");
        
        foreach (var algorithm in algorithms)
        {
            // measure execution time
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var result = algorithm.TargetSum(testCase.Nums, testCase.Target);
            watch.Stop();
            Console.WriteLine($"{algorithm.Name}: {(result == testCase.Expected ? "Test Passed" : "Test Failed")} in {watch.ElapsedTicks}ticks");
        }
    }
    
    private TargetSumCase[] Cases
    {
        get
        {
            return new[]
            {
                new TargetSumCase()
                {
                    Nums = new int[] {1, 1, 1, 1, 1},
                    Target = 3,
                    Expected = 5
                },
                new TargetSumCase()
                {
                    Nums = new int[] {1},
                    Target = 1,
                    Expected = 1
                }
            };
        }
    }
}

public class TargetSumCase : TestCase
{
    public int[] Nums { get; set; }
    public int Target { get; set; }
    public int Expected { get; set; }
    public override string Description { get; }
}