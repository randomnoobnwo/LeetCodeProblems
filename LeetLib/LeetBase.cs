namespace LeetLib;

public abstract class LeetBase
{
    public virtual void Execute()
    {
        Console.WriteLine($"Executing {Name}");
    }
    public abstract string Name { get; }
}