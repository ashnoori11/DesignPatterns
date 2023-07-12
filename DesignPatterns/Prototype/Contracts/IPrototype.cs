namespace DesignPatterns.Prototype.Contracts;

public interface IPrototype<T> where T : class
{
    T Clone();
}
