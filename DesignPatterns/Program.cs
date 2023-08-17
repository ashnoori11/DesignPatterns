// version .net 6 (long term support)
using DesignPatterns.Factory.Interfaces;
using DesignPatterns.Factory;
using DesignPatterns.Builder.Models;
using DesignPatterns.Builder;
using DesignPatterns.Prototype;
using DesignPatterns.Singleton;
using DesignPatterns.Adapter.Interface;
using DesignPatterns.Adapter;
using DesignPatterns.Bridge.Contracts;
using DesignPatterns.Bridge;

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

        #region singleton
        CurrencyConverter converter = CurrencyConverter.Instance;

        converter.SetExchangeRate("USD", 1.0m);
        converter.SetExchangeRate("EUR", 0.85m);
        converter.SetExchangeRate("GBP", 0.72m);

        decimal amount = 100.0m;
        string fromCurrency = "USD";
        string toCurrency = "EUR";

        decimal convertedAmount = converter.ConvertCurrency(amount, fromCurrency, toCurrency);

        Console.WriteLine($"{amount} {fromCurrency} = {convertedAmount} {toCurrency}");
        #endregion

        #region Adapter
        // Create an instance of the third-party payment gateway
        ThirdPartyPaymentGateway paymentGateway = new ThirdPartyPaymentGateway();

        // Create an instance of the adapter, passing the third-party payment gateway
        IPaymentProcessor paymentProcessor = new PaymentGatewayAdapter(paymentGateway);

        // Call the process payment method on the adapter
        paymentProcessor.ProcessPayment(100.50m);
        #endregion

        #region Bridge
        Console.WriteLine("***Bridge Pattern Demo***\n");

        //a square with red color
        Console.WriteLine("\nCreating a Rectangle object with red color...");
        Shape rectangleShape = new Rectangle(new RedColor());
        rectangleShape.DrawShape(20);

        //a circle with green color
        Console.WriteLine("\n\nCreating a Circle object with green color...");
        Shape circleShape = new Circle(new GreenColor());
        circleShape.DrawShape(10);

        Console.ReadLine();
        #endregion
    }
}