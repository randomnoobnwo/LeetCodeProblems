using System.Collections;

namespace LeetLib;

public class PalindromeNumberExec : LeetBase
{
    public override void Execute()
    {
        base.Execute();
        foreach (var numberCase in Cases)
        {
            CheckCase(numberCase, new PalindromeNumberBase[] { new PalindromeNumberCheckString(), new PalindromeNumberNoStrings() });
        }
    }

    protected override string Name => "9. Palindrome Number";

    private void CheckCase(PalindromeNumberCase numberCase, PalindromeNumberBase[] algorithms)
    {
        Console.WriteLine($"Case: {numberCase.Description}");
        
        foreach (var algorithm in algorithms)
        {
            var result = algorithm.IsPalindrome(numberCase.X);
            Console.WriteLine($"{algorithm.Name}: {(result == numberCase.Expected ? "Test Passed" : "Test Failed")}");
        }
    }

    private PalindromeNumberCase[] Cases
    {
        get
        {
            return new[]
            {
                new PalindromeNumberCase
                {
                    X = 121,
                    Expected = true
                },
                new PalindromeNumberCase
                {
                    X = -121,
                    Expected = false
                },
                new PalindromeNumberCase
                {
                    X = 10,
                    Expected = false
                },
                new PalindromeNumberCase
                {
                    X = -101,
                    Expected = false
                },
                new PalindromeNumberCase
                {
                    X = 0,
                    Expected = true
                },
                new PalindromeNumberCase
                {
                    X = 1221,
                    Expected = true
                },
            };
        }
    }
    
    
}

public class PalindromeNumberCase : TestCase
{
    public int X { get; set; }
    public bool Expected { get; set; }

    public override string Description => $"X: {X}";
}