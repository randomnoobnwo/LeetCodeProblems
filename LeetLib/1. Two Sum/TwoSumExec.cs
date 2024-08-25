namespace LeetLib;

public class TwoSumExec : LeetBase
{
    private TwoSumCase[] Cases
    {
        get
        {
            return new[]
            {
                new TwoSumCase
                {
                    Nums = new[] {2, 7, 11, 15},
                    Target = 9,
                    Expected = new[] {0, 1}
                },
                new TwoSumCase
                {
                    Nums = new[] {3, 2, 4},
                    Target = 6,
                    Expected = new[] {1, 2}
                },
                new TwoSumCase
                {
                    Nums = new[] {3, 3},
                    Target = 6,
                    Expected = new[] {0, 1}
                }
            };
        }
    }
    
    public override void Execute()
    {
        base.Execute();
        foreach (var testCase in Cases)
        {
            CheckCase(testCase, [new TwoSumBruteForce(), new TwoSumHashmap()]);
        }
    }

    public override string Name => "1. Two Sum";

    private void CheckCase(TwoSumCase testCase, TwoSum1[] algorithms)
    {
        Console.WriteLine($"Case: {string.Join(", ", testCase.Nums)} Target: {testCase.Target}");
        
        foreach (var algorithm in algorithms)
        {
            var result = algorithm.TwoSum(testCase.Nums, testCase.Target);
            Console.WriteLine($"{algorithm.Name}: {(CasePassed(result, testCase.Expected) ? "Test Passed" : "Test Failed")}");
        }
    }
    
    private bool CasePassed(int[] result, int[] expected)
    {
        return result[0] == expected[0] && result[1] == expected[1];
    }
}

internal class TwoSumCase
{
    public int[] Nums { get; set; }
    public int Target { get; set; }
    public int[] Expected { get; set; }
}