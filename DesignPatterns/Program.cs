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
using DesignPatterns.Composite;
using DesignPatterns.Decorator.Contracts;
using DesignPatterns.Decorator;
using DesignPatterns.Facade;
using DesignPatterns.AbstractClasses;
using Microsoft.VisualBasic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;
using System.Security.Claims;

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
        Shape circleShape = new DesignPatterns.Bridge.Circle(new GreenColor());
        circleShape.DrawShape(10);

        Console.ReadLine();
        #endregion

        #region Composite
        // Build a composite tree structure
        DesignPatterns.Composite.Composite computer = new DesignPatterns.Composite.Composite("Computer");
        DesignPatterns.Composite.Composite cabinet = new DesignPatterns.Composite.Composite("Cabinet");
        DesignPatterns.Composite.Composite peripherals = new DesignPatterns.Composite.Composite("Peripherals");

        computer.Add(cabinet);
        computer.Add(peripherals);

        cabinet.Add(new Leaf("Mother Board"));
        cabinet.Add(new Leaf("CPU"));
        cabinet.Add(new Leaf("Hard Disk"));

        peripherals.Add(new Leaf("Mouse"));
        peripherals.Add(new Leaf("Keyboard"));

        // Display the composite tree structure
        computer.Display(1);
        #endregion

        #region Decorator
        // Create a Circle object.
        IShape circle = new DesignPatterns.Decorator.Circle();

        // Wrap the Circle object with a ColorDecorator.
        IShape coloredCircle = new ColorDecorator(circle, "red");

        // Draw the colored circle.
        coloredCircle.Draw();
        #endregion

        #region Facade
        // Create an instance of the Facade class
        ECommerceFacade ecommerce = new ECommerceFacade();

        // Add a product
        ecommerce.AddProduct("Product 1", 100.0);

        // Place an order
        ecommerce.PlaceOrder("Customer 1", "Product 1");

        // Process payment
        ecommerce.ProcessPayment("Customer 1", 100.0);
        #endregion

        #region Important note
        //In C#, an **abstract class** is a class that cannot be instantiated. Instead, it serves as a base class for other classes to inherit from.
        //Abstract classes are used to define a common set of behaviors or properties that derived classes should have.
        //To create an abstract class in C#, you use the “abstract” keyword before the class definition. Here is an example:
        Animal[] animals = new Animal[] { new Cat(), new Dog() };
        foreach (Animal animal in animals)
        {
            Console.WriteLine($"The {animal.GetType().Name} goes {animal.Sound}");
            animal.Move();
        }

        //Abstraction in C# is the process to hide the internal details and show only the functionality.
        //The abstract modifier indicates the incomplete implementation.
        //The keyword abstract is used before the class or method to declare the class or method as abstract.
        //Also, the abstract modifier can be used with indexers, events, and properties.

        //An **abstract method** is a method that is declared abstract,
        //has no “body” and is declared inside the abstract class only.
        //An abstract method must be implemented in all non-abstract classes using the override keyword.
        //After overriding, the abstract method is in the non-Abstract class.
        //We can derive this class in another class, and again we can override the same abstract method with it.
        //An ** abstract class** is never intended to be instantiated directly.
        //An abstract class can also be created without any abstract methods.
        //We can mark a class abstract even if it doesn’t have any abstract method.
        //The Abstract classes are typically used to define a base class in the class hierarchy.
        //Or in other words, an abstract class is an incomplete class or a special class we can’t be instantiated.
        //The purpose of an abstract class is to provide a blueprint for derived classes and set some rules that the derived classes must implement when they inherit an abstract class.
        //We can use an abstract class as a base class and all derived classes must implement abstract definitions.


        //https://www.geeksforgeeks.org/c-sharp-abstract-classes/.
        //https://www.c-sharpcorner.com/article/c-sharp-abstract-classes-definition-usage-with-example/.
        //https://www.codingninjas.com/studio/library/difference-between-abstract-class-and-interface-in-c-sharp.
        //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract.
        //https://computinglearner.com/abstract-class-in-object-oriented-programming/.
        #endregion
    }
}
