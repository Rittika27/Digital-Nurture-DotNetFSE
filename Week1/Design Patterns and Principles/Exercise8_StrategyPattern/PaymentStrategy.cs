public interface IPaymentStrategy
{
    void Pay(double amount);
}

public class CreditCardPayment : IPaymentStrategy
{
    public void Pay(double amount) =>
        Console.WriteLine($"Credit Card: Paid ${amount}");
}

public class PayPalPayment : IPaymentStrategy
{
    public void Pay(double amount) =>
        Console.WriteLine($"PayPal: Paid ${amount}");
}

public class PaymentContext
{
    private IPaymentStrategy _strategy;
    public PaymentContext(IPaymentStrategy strategy) => _strategy = strategy;
    public void SetStrategy(IPaymentStrategy strategy) => _strategy = strategy;
    public void ExecutePayment(double amount) => _strategy.Pay(amount);
}
