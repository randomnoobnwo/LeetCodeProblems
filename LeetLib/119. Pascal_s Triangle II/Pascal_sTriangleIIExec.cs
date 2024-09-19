namespace LeetLib;

public class Pascal_sTriangleIIExec : LeetBase
{
    public override void Execute()
    {
        base.Execute();
        foreach (var testCase in Cases)
        {
            CheckCase(testCase, [new Pascal_sTriangleIIV1()]);
        }
    }

    protected override string Name => "119. Pascal_s Triangle II";
    
    private void CheckCase(Pascal_sTriangleIICase testCase, Pascal_sTriangleIIBase[] algorithms)
    {
        Console.WriteLine($"Case: {testCase.Description}");
        
        foreach (var algorithm in algorithms)
        {
            // measure execution time
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var result = algorithm.GetRow(testCase.rowIndex);
            watch.Stop();
            Console.WriteLine($"{algorithm.Name}: {(VerifyCase(result, testCase.Expected) ? "Test Passed" : "Test Failed")} in {watch.ElapsedTicks}ticks");
        }
    }
    
    private bool VerifyCase(IList<int> result, IList<int> expected)
    {
        if (result.Count != expected.Count)
        {
            return false;
        }
        
        for (int i = 0; i < result.Count; i++)
        {
            if (result[i] != expected[i])
            {
                return false;
            }
        }
        
        return true;
    }
    
    private Pascal_sTriangleIICase[] Cases
    {
        get
        {
            return new[]
            {
                new Pascal_sTriangleIICase()
                {
                    rowIndex = 3,
                    Expected = new List<int> { 1, 3, 3, 1 }
                },
                new Pascal_sTriangleIICase()
                {
                    rowIndex = 0,
                    Expected = new List<int> { 1 }
                },
                new Pascal_sTriangleIICase()
                {
                    rowIndex = 1,
                    Expected = new List<int> { 1, 1 }
                }
            };
        }
    }
}

public class Pascal_sTriangleIICase : TestCase
{
    public int rowIndex;
    public IList<int> Expected { get; set; }
    public override string Description { get; }
}