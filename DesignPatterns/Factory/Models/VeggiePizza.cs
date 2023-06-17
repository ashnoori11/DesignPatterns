using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.Models;


public class VeggiePizza : IPizza
{
    public void Prepare()
    {
        Console.WriteLine("Preparing Veggie Pizza");
    }

    public void Bake()
    {
        Console.WriteLine("Baking Veggie Pizza");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting Veggie Pizza");
    }

    public void Box()
    {
        Console.WriteLine("Boxing Veggie Pizza");
    }
}
