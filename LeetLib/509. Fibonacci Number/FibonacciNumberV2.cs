namespace LeetLib;

public class FibonacciNumberV2 : FibonacciNumberBase
{
    public override int Fib(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        
        return Fib(n - 1) + Fib(n - 2);
    }

    public override string Name => "V2";
}