// version .net 6 (long term support)
using DesignPatterns.Factory.Interfaces;
using DesignPatterns.Factory;
using DesignPatterns.Builder.Models;
using DesignPatterns.Builder;
using DesignPatterns.Prototype;

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

        #region builder
        var sportsCarBuilder = new SportsCarBuilder();
        var director = new Director(sportsCarBuilder);

        director.ConstructCar();
        Car sportsCar = sportsCarBuilder.GetCar();
        #endregion

        #region prototype
        // Create a person object.
        var person = new Person
        {
            Name = "John",
            Age = 30,
            Address = new Address
            {
                Street = "123 Main St",
                City = "Anytown",
                State = "CA"
            }
        };

        // Clone the person object.
        var clonedPerson = person.Clone();

        // Modify the cloned person object.
        clonedPerson.Name = "Jane";
        clonedPerson.Age = 25;
        clonedPerson.Address.Street = "456 Elm St";

        // Output the original and cloned person objects.
        Console.WriteLine("Original: " + person);
        Console.WriteLine("Cloned: " + clonedPerson);
        #endregion
    }
}