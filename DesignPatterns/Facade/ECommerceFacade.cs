namespace DesignPatterns.Facade;

// Define the Facade class
public class ECommerceFacade
{
    private ProductSubsystem _product;
    private OrderSubsystem _order;
    private PaymentSubsystem _payment;

    public ECommerceFacade()
    {
        _product = new ProductSubsystem();
        _order = new OrderSubsystem();
        _payment = new PaymentSubsystem();
    }

    public void AddProduct(string name, double price)
    {
        Console.WriteLine("Adding product...");
        _product.AddProduct(name, price);
    }

    public void PlaceOrder(string customerName, string productName)
    {
        Console.WriteLine("Placing order...");
        int productId = _product.GetProductId(productName);
        _order.PlaceOrder(customerName, productId);
    }

    public void ProcessPayment(string customerName, double amount)
    {
        Console.WriteLine("Processing payment...");
        int orderId = _order.GetOrderId(customerName);
        _payment.ProcessPayment(orderId, amount);
    }
}
