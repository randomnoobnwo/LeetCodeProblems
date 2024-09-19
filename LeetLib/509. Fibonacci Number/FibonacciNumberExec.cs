namespace LeetLib;

public class FibonacciNumberExec : LeetBase
{
    public override void Execute()
    {
        base.Execute();
        foreach (var testCase in Cases)
        {
            CheckCase(testCase, [new FibonacciNumberV1()]);
        }
    }

    protected override string Name => "509. Fibonacci Number";
    
    private void CheckCase(FibonacciNumberCase testCase, FibonacciNumberBase[] algorithms)
    {
        Console.WriteLine($"Case: {testCase.Description}");
        
        foreach (var algorithm in algorithms)
        {
            // measure execution time
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var result = algorithm.Fib(testCase.n);
            watch.Stop();
            Console.WriteLine($"{algorithm.Name}: {(result == testCase.Expected ? "Test Passed" : "Test Failed")} in {watch.ElapsedTicks}ticks");
        }
    }
    
    private FibonacciNumberCase[] Cases
    {
        get
        {
            return new[]
            {
                new FibonacciNumberCase()
                {
                    n = 2,
                    Expected = 1
                },
                new FibonacciNumberCase()
                {
                    n = 3,
                    Expected = 2
                },
                new FibonacciNumberCase()
                {
                    n = 4,
                    Expected = 3
                },
                new FibonacciNumberCase()
                {
                    n = 5,
                    Expected = 5
                },
            };
        }
    }
}

public class FibonacciNumberCase : TestCase
{
     public int n;
    public int Expected { get; set; }
    public override string Description { get; }
}