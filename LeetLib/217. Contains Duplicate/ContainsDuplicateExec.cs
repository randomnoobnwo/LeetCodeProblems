namespace LeetLib;

public class ContainsDuplicateExec : LeetBase
{
    public override void Execute()
    {
        base.Execute();
        foreach (var testCase in Cases)
        {
            CheckCase(testCase, new ContainsDuplicateBase[] { new ContainsDuplicateHashmap() });
        }
    }

    protected override string Name => "217. Contains Duplicate";
    
    private void CheckCase(ContainsDuplicateCase testCase, ContainsDuplicateBase[] algorithms)
    {
        Console.WriteLine($"Case: {testCase.Description}");
        
        foreach (var algorithm in algorithms)
        {
            var result = algorithm.ContainsDuplicate(testCase.Nums);
            Console.WriteLine($"{algorithm.Name}: {(result == testCase.Expected ? "Test Passed" : "Test Failed")}");
        }
    }
    
    private ContainsDuplicateCase[] Cases
    {
        get
        {
            return new[]
            {
                new ContainsDuplicateCase
                {
                    Nums = new[] {1, 2, 3, 1},
                    Expected = true
                },
                new ContainsDuplicateCase
                {
                    Nums = new[] {1, 2, 3, 4},
                    Expected = false
                },
                new ContainsDuplicateCase
                {
                    Nums = new[] {1, 1, 1, 3, 3, 4, 3, 2, 4, 2},
                    Expected = true
                }
            };
        }
    }
}

public class ContainsDuplicateCase : TestCase
{
    public int[] Nums { get; set; }
    public bool Expected { get; set; }
    public override string Description => $"Nums: {string.Join(", ", Nums)}";
}