using System.Collections;

namespace LeetLib;

public class Pascal_sTriangleExec : LeetBase
{
    public override void Execute()
    {
        base.Execute();
        foreach (var testCase in Cases)
        {
            CheckCase(testCase, new Pascal_sTriangleBase[] { new Pascal_sTriangleV1(), new Pascal_sTriangleV2(), new Pascal_sTriangleV3() });
        }
    }

    protected override string Name => "118. Pascal_s Triangle";
    
    private void CheckCase(Pascal_sTriangleCase testCase, Pascal_sTriangleBase[] algorithms)
    {
        Console.WriteLine($"Case: {testCase.Description}");
        
        foreach (var algorithm in algorithms)
        {
            // measure execution time
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var result = algorithm.Pascal_sTriangle(testCase.NumRows);
            watch.Stop();
            Console.WriteLine($"{algorithm.Name}: {(CheckResults(result, testCase.Expected) ? "Test Passed" : "Test Failed")} in {watch.ElapsedTicks}ticks");
        }
    }
    
    private bool CheckResults(IList<IList<int>> result, IList<IList<int>> expected)
    {
        if (result.Count != expected.Count)
        {
            return false;
        }
        
        for (int i = 0; i < result.Count; i++)
        {
            if (result[i].Count != expected[i].Count)
            {
                return false;
            }
            
            for (int j = 0; j < result[i].Count; j++)
            {
                if (result[i][j] != expected[i][j])
                {
                    return false;
                }
            }
        }
        
        return true;
    }
    
    private Pascal_sTriangleCase[] Cases
    {
        get
        {
            return new Pascal_sTriangleCase[]
            {
                new Pascal_sTriangleCase()
                {
                    NumRows = 5,
                    Expected = [[1], [1, 1], [1, 2, 1], [1, 3, 3, 1], [1, 4, 6, 4, 1]]
                },
                new Pascal_sTriangleCase()
                {
                    NumRows = 1,
                    Expected = [[1]]
                }
            };
        }
    }
}

public class Pascal_sTriangleCase : TestCase
{
    public int NumRows { get; set; }
    public IList<IList<int>> Expected { get; set; }
    public override string Description { get; }
}