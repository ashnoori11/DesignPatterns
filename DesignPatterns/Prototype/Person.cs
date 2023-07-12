using DesignPatterns.Prototype.Contracts;

namespace DesignPatterns.Prototype;

public class Person :Prototype<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Address Address { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Address: {Address}";
    }
}
