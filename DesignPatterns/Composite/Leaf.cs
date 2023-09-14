namespace DesignPatterns.Composite;

public class Leaf : Electronics
{
    public Leaf(string name)
    {
        this.Name = name;
    }

    public override void Add(Electronics c)
    {
        Console.WriteLine("Cannot add to a leaf");
    }

    public override void Remove(Electronics c)
    {
        Console.WriteLine("Cannot remove from a leaf");
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + Name);
    }
}
