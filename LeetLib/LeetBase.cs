namespace LeetLib;

public abstract class LeetBase
{
    public virtual void Execute()
    {
        Console.WriteLine($"---==== {Name} ===---");
    }

    protected abstract string Name { get; }
}