namespace DesignPatterns.AbstractClasses;

public abstract class Animal
{
    public abstract string Sound { get; }
    public virtual void Move()
    {
        Console.WriteLine("Moving...");
    }
}

public class Cat : Animal
{
    public override string Sound => "Meow";
    public override void Move()
    {
        Console.WriteLine("Walking like a cat...");
    }
}

public class Dog : Animal
{
    public override string Sound => "Woof";
    public override void Move()
    {
        Console.WriteLine("Running like a dog...");
    }
}