namespace DesignPatterns.Facade;

// Define the Subsystem classes
public class ProductSubsystem
{
    private Dictionary<string, int> _products;
    private int _nextProductId;

    public ProductSubsystem()
    {
        _products = new Dictionary<string, int>();
        _nextProductId = 1;
    }

    public void AddProduct(string name, double price)
    {
        int productId = _nextProductId++;
        Console.WriteLine($"Added product {name} with ID {productId} and price {price}");
        _products.Add(name, productId);
    }

    public int GetProductId(string name)
    {
        return _products[name];
    }
}
