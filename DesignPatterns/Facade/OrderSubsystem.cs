namespace DesignPatterns.Facade;

public class OrderSubsystem
{
    private Dictionary<int, string> _orders;
    private int _nextOrderId;

    public OrderSubsystem()
    {
        _orders = new Dictionary<int, string>();
        _nextOrderId = 1;
    }

    public void PlaceOrder(string customerName, int productId)
    {
        int orderId = _nextOrderId++;
        Console.WriteLine($"Placed order {orderId} for customer {customerName} with product ID {productId}");
        _orders.Add(orderId, customerName);
    }

    public int GetOrderId(string customerName)
    {
        return _orders.FirstOrDefault(x => x.Value == customerName).Key;
    }
}
