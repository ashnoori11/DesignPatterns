using DesignPatterns.Bridge.Contracts;

namespace DesignPatterns.Bridge;

public class Circle : Shape
{
    public Circle(IColor c) : base(c)
    {
    }

    public override void DrawShape(int border)
    {
        Console.Write("This Circle is colored with: ");
        color.FillWithColor(border);
    }
}
