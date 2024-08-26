namespace LeetLib;

public class ValidAnagramExec : LeetBase
{
    public override void Execute()
    {
        base.Execute();
        foreach (var testCase in Cases)
        {
            CheckCase(testCase, new ValidAnagramBase[] { new ValidAnagramV1(), new ValidAnagramV2() });
        }
    }

    protected override string Name => "242. Valid Anagram";
    
    private void CheckCase(ValidAnagramCase testCase, ValidAnagramBase[] algorithms)
    {
        Console.WriteLine($"Case: {string.Join(", ", testCase)}");
        
        foreach (var algorithm in algorithms)
        {
            // measure execution time
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var result = algorithm.ValidAnagram(testCase.S, testCase.T);
            watch.Stop();
            Console.WriteLine($"{algorithm.Name}: {(result == testCase.Expected ? "Test Passed" : "Test Failed")} in {watch.ElapsedTicks}ticks");
        }
    }
    
    private ValidAnagramCase[] Cases
    {
        get
        {
            return new[]
            {
                new ValidAnagramCase
                {
                    S = "anagram",
                    T = "nagaram",
                    Expected = true
                },
                new ValidAnagramCase
                {
                    S = "rat",
                    T = "car",
                    Expected = false
                }
            };
         
        }
    }
}

public class ValidAnagramCase
{
    public string S { get; set; }
    public string T { get; set; }
    public bool Expected { get; set; }
}