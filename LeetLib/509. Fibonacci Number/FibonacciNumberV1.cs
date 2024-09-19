namespace LeetLib;

public class FibonacciNumberV1 : FibonacciNumberBase
{
    public override int Fib(int n)
    {
        var d = new Dictionary<int, int>();

        return F(n);

        int F(int num)
        {
            if (num == 0) return 0;
            if (num == 1) return 1;

            if (d.TryGetValue(num, out var f))
                return f;
            
            var res = F(num - 1) + F(num - 2);
            d[num] = res;
            return res;
        }
    }

    public override string Name => "V1";
}