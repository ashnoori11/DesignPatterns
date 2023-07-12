namespace DesignPatterns.Prototype.Contracts;

public abstract class Prototype<T> : IPrototype<T> where T : class
{
    public T Clone()
    {
        // Use MemberwiseClone to create a shallow copy of the object.
        return (T)this.MemberwiseClone();
    }
}
