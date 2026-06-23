public class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public double TotalPrice { get; set; }

    public override string ToString() => $"Order#{OrderId} | {CustomerName} | ${TotalPrice}";
}

public static class Sorter
{
    // O(n^2)
    public static void BubbleSort(Order[] orders)
    {
        int n = orders.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (orders[j].TotalPrice > orders[j + 1].TotalPrice)
                    (orders[j], orders[j + 1]) = (orders[j + 1], orders[j]);
    }

    // O(n log n) average
    public static void QuickSort(Order[] orders, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(orders, low, high);
            QuickSort(orders, low, pi - 1);
            QuickSort(orders, pi + 1, high);
        }
    }

    private static int Partition(Order[] orders, int low, int high)
    {
        double pivot = orders[high].TotalPrice;
        int i = low - 1;
        for (int j = low; j < high; j++)
            if (orders[j].TotalPrice <= pivot)
                (orders[++i], orders[j]) = (orders[j], orders[i]);
        (orders[i + 1], orders[high]) = (orders[high], orders[i + 1]);
        return i + 1;
    }
}
