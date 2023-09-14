namespace DesignPatterns.Composite;

public class Composite : Electronics
{
    private List<Electronics> _children = new List<Electronics>();

    public Composite(string name)
    {
        this.Name = name;
    }

    public override void Add(Electronics component)
    {
        _children.Add(component);
    }

    public override void Remove(Electronics component)
    {
        _children.Remove(component);
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + Name);

        foreach (Electronics component in _children)
        {
            component.Display(depth + 2);
        }
    }
}
