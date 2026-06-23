public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public double Price { get; set; }

    public override string ToString() =>
        $"[{ProductId}] {ProductName} | Qty: {Quantity} | Price: ${Price}";
}

public class Inventory
{
    private readonly Dictionary<int, Product> _products = new();

    // O(1)
    public void Add(Product p)
    {
        _products[p.ProductId] = p;
        Console.WriteLine($"Added: {p.ProductName}");
    }

    // O(1)
    public void Update(int id, int qty, double price)
    {
        if (_products.TryGetValue(id, out var p))
        {
            p.Quantity = qty;
            p.Price = price;
            Console.WriteLine($"Updated: {p.ProductName}");
        }
        else Console.WriteLine($"Product {id} not found.");
    }

    // O(1)
    public void Delete(int id)
    {
        if (_products.Remove(id)) Console.WriteLine($"Deleted product ID {id}");
        else Console.WriteLine($"Product {id} not found.");
    }

    public void Display() => _products.Values.ToList().ForEach(p => Console.WriteLine(p));
}
