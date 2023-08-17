using DesignPatterns.Bridge.Contracts;

namespace DesignPatterns.Bridge;

public class Rectangle : Shape
{
    public Rectangle(IColor c) : base(c)
    {
    }

    public override void DrawShape(int border)
    {
        Console.Write("This Rectangle is colored with: ");
        color.FillWithColor(border);
    }
}
