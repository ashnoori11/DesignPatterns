namespace DesignPatterns.Adapter;

public class ThirdPartyPaymentGateway
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Payment of {amount} processed via third-party gateway.");
    }
}
