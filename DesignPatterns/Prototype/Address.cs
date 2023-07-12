using DesignPatterns.Prototype.Contracts;

namespace DesignPatterns.Prototype;

public class Address : Prototype<Address>
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }

    public override string ToString()
    {
        return $"{Street}, {City}, {State}";
    }
}
