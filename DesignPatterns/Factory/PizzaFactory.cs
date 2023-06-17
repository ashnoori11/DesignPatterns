using DesignPatterns.Factory.Interfaces;
using DesignPatterns.Factory.Models;

namespace DesignPatterns.Factory;

public class PizzaFactory
{
    public IPizza CreatePizza(string type)
    {
        IPizza pizza = null;

        if (type == "Cheese")
        {
            pizza = new CheesePizza();
        }
        else if (type == "Pepperoni")
        {
            pizza = new PepperoniPizza();
        }
        else if (type == "Veggie")
        {
            pizza = new VeggiePizza();
        }

        return pizza;
    }
}
