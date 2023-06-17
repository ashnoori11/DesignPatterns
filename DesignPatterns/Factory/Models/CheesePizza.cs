using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.Models;

public class CheesePizza : IPizza
{
    public void Prepare()
    {
        Console.WriteLine("Preparing Cheese Pizza");
    }

    public void Bake()
    {
        Console.WriteLine("Baking Cheese Pizza");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting Cheese Pizza");
    }

    public void Box()
    {
        Console.WriteLine("Boxing Cheese Pizza");
    }
}
