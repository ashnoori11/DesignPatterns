// version .net 6 (long term support)
using DesignPatterns.Factory.Interfaces;
using DesignPatterns.Factory;

namespace DesignPatterns; // Note: actual namespace depends on the project name.

public class Program
{
    static void Main(string[] args)
    {
        #region Factory
        PizzaFactory pizzaFactory = new PizzaFactory();

        IPizza cheesePizza = pizzaFactory.CreatePizza("Cheese");
        cheesePizza.Prepare();
        cheesePizza.Bake();
        cheesePizza.Cut();
        cheesePizza.Box();

        IPizza pepperoniPizza = pizzaFactory.CreatePizza("Pepperoni");
        pepperoniPizza.Prepare();
        pepperoniPizza.Bake();
        pepperoniPizza.Cut();
        pepperoniPizza.Box();

        IPizza veggiePizza = pizzaFactory.CreatePizza("Veggie");
        veggiePizza.Prepare();
        veggiePizza.Bake();
        veggiePizza.Cut();
        veggiePizza.Box();
        #endregion
    }
}