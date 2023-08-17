namespace DesignPatterns.Bridge.Contracts;

public abstract class Shape
{
    protected IColor color;

    protected Shape(IColor c)
    {
        this.color = c;
    }

    public abstract void DrawShape(int border);
}
