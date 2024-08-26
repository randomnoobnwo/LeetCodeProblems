namespace LeetLib;

public abstract class LeetBase
{
    public virtual void Execute()
    {
        Console.WriteLine($"Executing {Name}");
    }

    protected abstract string Name { get; }
}