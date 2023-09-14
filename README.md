# DesignPatterns

## Factory

#### The PizzaFactory class is responsible for creating instances of concrete pizza classes based on the type of pizza requested. It has a single method called CreatePizza that takes a string parameter type representing the type of pizza to be created, and returns an instance of the requested pizza as an object of type IPizza.

### Here's how the CreatePizza method works:

- It first initializes a variable pizza of type IPizza to null.

- It then checks the value of the type parameter against different pizza types, such as "Cheese", "Pepperoni", and "Veggie" using if-else statements.

- If the type parameter matches a pizza type, such as "Cheese", it creates an instance of the corresponding concrete pizza class, such as CheesePizza, using the new keyword and assigns it to the pizza variable.

- Finally, it returns the pizza variable, which contains an instance of the requested pizza as an object of type IPizza.

### Here's an example usage of the PizzaFactory class:

```
PizzaFactory pizzaFactory = new PizzaFactory();
IPizza cheesePizza = pizzaFactory.CreatePizza("Cheese");
```

- In this case, the CreatePizza method is called with the parameter "Cheese", which matches the "Cheese" pizza type. The method creates an instance of the CheesePizza class and returns it as an object of type IPizza, which is then assigned to the cheesePizza variable.

- The cheesePizza variable now contains an instance of the CheesePizza class, which can be used to call its methods such as Prepare(), Bake(), Cut(), and Box().

-------------------------------------------------------------------------------------------------------

## Builder

#### Let's say you are building a car. The car can have various features such as a sunroof, a navigation system, and leather seats. To build the car, you can use the Builder pattern to create a CarBuilder class that allows you to specify the features of the car step-by-step.

```
var sportsCarBuilder = new SportsCarBuilder();
var director = new Director(sportsCarBuilder);

director.ConstructCar();
Car sportsCar = sportsCarBuilder.GetCar();
```

- In our example, you can see that the CarBuilder class separates the construction of the Car object from its representation, allowing you to create different types and representations of a car using the same construction code.
-  The Director class provides a way to construct the car step-by-step, and the ConcreteBuilder class implements the steps to construct the car with specific features.

-----------------------------------------------------------------------------------------------------------------

## Prototype

#### The Prototype design pattern is useful when you need to create new objects based on existing ones, but with some differences. Instead of creating a new object from scratch, you can clone an existing object and modify its properties as needed. This can save time and reduce code duplication, especially when dealing with complex objects or object hierarchies.

#### Here are some specific situations where the Prototype pattern might be useful:

- When creating new objects is complex: If creating a new object requires a lot of initialization code or configuration, it can be more efficient to clone an existing object and modify its properties instead of starting from scratch.

- When you need to avoid subclassing: Subclassing can lead to a large number of specialized classes that can be difficult to manage. The Prototype pattern allows you to create new objects without creating new classes, which can simplify your codebase.

- When you need to minimize memory usage: Creating new objects can be memory-intensive, especially if they contain a lot of data or are part of a large object hierarchy. Cloning an existing object can be more memory-efficient, since you're only creating a copy of the object's data instead of creating a new object from scratch.

- When you need to create objects dynamically: The Prototype pattern allows you to create new objects at runtime based on user input or other dynamic factors. This can be useful in situations where you don't know the exact type of object you need to create until runtime.


```
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

        var clonedPerson = person.Clone();

        clonedPerson.Name = "Jane";
        clonedPerson.Age = 25;
        clonedPerson.Address.Street = "456 Elm St";
```

-----------------------------------------------------------------------------------------------------------------

## Singleton

#### By using the Singleton pattern, we ensure that there is only one instance of the CurrencyConverter class throughout the application, allowing us to maintain a centralized and consistent set of exchange rates.


```
CurrencyConverter converter = CurrencyConverter.Instance;

converter.SetExchangeRate("USD", 1.0m);
converter.SetExchangeRate("EUR", 0.85m);
converter.SetExchangeRate("GBP", 0.72m);

decimal amount = 100.0m;
string fromCurrency = "USD";
string toCurrency = "EUR";

decimal convertedAmount = converter.ConvertCurrency(amount, fromCurrency, toCurrency);

Console.WriteLine($"{amount} {fromCurrency} = {convertedAmount} {toCurrency}");
```

-----------------------------------------------------------------------------------------------------------------

## Adapter

- In this example, we have a ThirdPartyPaymentGateway class that represents a third-party payment gateway library. It has a method Pay that accepts a double amount.

- The IPaymentProcessor interface represents the target interface that our client code expects. It defines a ProcessPayment method that accepts a decimal amount.

- The PaymentGatewayAdapter class implements the IPaymentProcessor interface and acts as an adapter between our client code and the ThirdPartyPaymentGateway. It takes an instance of the ThirdPartyPaymentGateway in its constructor and converts the decimal amount to a double before calling the Pay method on the third-party payment gateway.

- In the client code, we create an instance of the ThirdPartyPaymentGateway, then create an instance of the PaymentGatewayAdapter, passing the ThirdPartyPaymentGateway instance to it. Finally, we call the ProcessPayment method on the adapter, which internally calls the Pay method of the ThirdPartyPaymentGateway, effectively adapting the third-party payment gateway to our target interface.

```
        // Create an instance of the third-party payment gateway
        ThirdPartyPaymentGateway paymentGateway = new ThirdPartyPaymentGateway();

        // Create an instance of the adapter, passing the third-party payment gateway
        IPaymentProcessor paymentProcessor = new PaymentGatewayAdapter(paymentGateway);

        // Call the process payment method on the adapter
        paymentProcessor.ProcessPayment(100.50m);
```

------------------------------------------------------------------------------------------------------------------

## Bridge

- The Bridge Design Pattern is a structural design pattern that decouples an abstraction from its implementation so that the two can vary independently.
-  It falls under the category of Structural Design Pattern.
-   The Bridge Design Pattern allows both Abstraction and Implementation to be developed independently and the client code can only access the Abstraction part without being concerned about the Implementation part.
-    The Bridge Design Pattern separates the Abstraction hierarchy and the Implementation hierarchy into two different layers so that change in one Hierarchy will not affect the development or functionality of another Hierarchy1.

```
        //a square with red color
        Console.WriteLine("\nCreating a Rectangle object with red color...");
        Shape rectangleShape = new Rectangle(new RedColor());
        rectangleShape.DrawShape(20);

        //a circle with green color
        Console.WriteLine("\n\nCreating a Circle object with green color...");
        Shape circleShape = new Circle(new GreenColor());
        circleShape.DrawShape(10);
```
