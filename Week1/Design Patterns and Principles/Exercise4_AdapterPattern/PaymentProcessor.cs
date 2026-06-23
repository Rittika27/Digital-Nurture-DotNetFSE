public interface IPaymentProcessor
{
    void ProcessPayment(double amount);
}

// Adaptee 1
public class PayPalGateway
{
    public void MakePayment(double amount) =>
        Console.WriteLine($"PayPal: Processing payment of ${amount}");
}

// Adaptee 2
public class StripeGateway
{
    public void Charge(double amount) =>
        Console.WriteLine($"Stripe: Charging ${amount}");
}

// Adapter 1
public class PayPalAdapter : IPaymentProcessor
{
    private readonly PayPalGateway _paypal = new();
    public void ProcessPayment(double amount) => _paypal.MakePayment(amount);
}

// Adapter 2
public class StripeAdapter : IPaymentProcessor
{
    private readonly StripeGateway _stripe = new();
    public void ProcessPayment(double amount) => _stripe.Charge(amount);
}
