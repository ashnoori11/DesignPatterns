namespace DesignPatterns.Facade;

public class PaymentSubsystem
{
    public void ProcessPayment(int orderId, double amount)
    {
        Console.WriteLine($"Processed payment of {amount} for order {orderId}");
    }
}
