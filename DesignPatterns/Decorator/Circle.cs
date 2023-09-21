using DesignPatterns.Decorator.Contracts;

namespace DesignPatterns.Decorator;

// The ConcreteComponent class represents the original object to which new functionalities can be added.
public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}
