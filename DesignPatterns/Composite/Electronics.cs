namespace DesignPatterns.Composite;

public abstract class Electronics
{
    public string Name { get; set; }
    public abstract void Add(Electronics component);
    public abstract void Remove(Electronics component);
    public abstract void Display(int depth);
}
