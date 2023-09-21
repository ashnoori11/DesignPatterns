using DesignPatterns.Decorator.Contracts;

namespace DesignPatterns.Decorator;

// The ConcreteDecorator class adds new functionalities to the ConcreteComponent object.
public class ColorDecorator : ShapeDecorator
{
    private string _color;

    public ColorDecorator(IShape shape, string color) : base(shape)
    {
        _color = color;
    }

    public override void Draw()
    {
        base.Draw();
        SetColor();
    }

    private void SetColor()
    {
        Console.WriteLine($"Setting color to {_color}.");
    }
}

