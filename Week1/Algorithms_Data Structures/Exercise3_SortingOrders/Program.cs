Order[] orders1 =
{
    new Order { OrderId = 1, CustomerName = "Alice", TotalPrice = 250.00 },
    new Order { OrderId = 2, CustomerName = "Bob",   TotalPrice = 120.00 },
    new Order { OrderId = 3, CustomerName = "Carol", TotalPrice = 480.00 },
    new Order { OrderId = 4, CustomerName = "Dave",  TotalPrice = 75.00  },
};

Order[] orders2 = (Order[])orders1.Clone();

Sorter.BubbleSort(orders1);
Console.WriteLine("Bubble Sort:");
Array.ForEach(orders1, o => Console.WriteLine(o));

Sorter.QuickSort(orders2, 0, orders2.Length - 1);
Console.WriteLine("\nQuick Sort:");
Array.ForEach(orders2, o => Console.WriteLine(o));

/*
 * Time Complexity:
 *   Bubble Sort : O(n^2) — nested loops, slow for large datasets
 *   Quick Sort  : O(n log n) avg — divide and conquer, preferred for large datasets
 */
