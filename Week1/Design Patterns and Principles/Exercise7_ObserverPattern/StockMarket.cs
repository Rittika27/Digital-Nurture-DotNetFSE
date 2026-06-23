public interface IObserver
{
    void Update(string stockName, double price);
}

public interface IStock
{
    void Register(IObserver observer);
    void Deregister(IObserver observer);
    void NotifyObservers();
}

public class StockMarket : IStock
{
    private readonly List<IObserver> _observers = new();
    private string _stockName = string.Empty;
    private double _price;

    public void Register(IObserver observer) => _observers.Add(observer);
    public void Deregister(IObserver observer) => _observers.Remove(observer);
    public void NotifyObservers() => _observers.ForEach(o => o.Update(_stockName, _price));

    public void SetPrice(string stockName, double price)
    {
        _stockName = stockName;
        _price = price;
        NotifyObservers();
    }
}

public class MobileApp : IObserver
{
    public void Update(string stockName, double price) =>
        Console.WriteLine($"MobileApp  -> {stockName}: ${price}");
}

public class WebApp : IObserver
{
    public void Update(string stockName, double price) =>
        Console.WriteLine($"WebApp     -> {stockName}: ${price}");
}
