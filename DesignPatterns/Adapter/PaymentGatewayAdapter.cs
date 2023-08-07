using DesignPatterns.Adapter.Interface;

namespace DesignPatterns.Adapter;

public class PaymentGatewayAdapter : IPaymentProcessor
{
    private ThirdPartyPaymentGateway _paymentGateway;

    public PaymentGatewayAdapter(ThirdPartyPaymentGateway paymentGateway)
    {
        _paymentGateway = paymentGateway;
    }

    public void ProcessPayment(decimal amount)
    {
        _paymentGateway.Pay((double)amount);
    }
}
