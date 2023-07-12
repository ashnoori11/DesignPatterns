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
