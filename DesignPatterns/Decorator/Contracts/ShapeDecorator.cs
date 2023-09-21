namespace DesignPatterns.Decorator.Contracts;

// The Decorator class is the base class for all decorators and holds a reference to the Component object.
public abstract class ShapeDecorator : IShape
{
    protected IShape _shape;

    public ShapeDecorator(IShape shape)
    {
        _shape = shape;
    }

    public virtual void Draw()
    {
        _shape.Draw();
    }
}
