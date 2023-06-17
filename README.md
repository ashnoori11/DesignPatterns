# DesignPatterns

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
