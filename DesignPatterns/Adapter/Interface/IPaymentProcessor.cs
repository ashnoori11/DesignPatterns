namespace DesignPatterns.Adapter.Interface;

public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}
