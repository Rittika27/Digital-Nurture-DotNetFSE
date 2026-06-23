Product[] products =
{
    new Product { ProductId = 3, ProductName = "Laptop",  Category = "Electronics" },
    new Product { ProductId = 7, ProductName = "Phone",   Category = "Electronics" },
    new Product { ProductId = 1, ProductName = "T-Shirt", Category = "Clothing"    },
    new Product { ProductId = 5, ProductName = "Shoes",   Category = "Footwear"    },
    new Product { ProductId = 9, ProductName = "Watch",   Category = "Accessories" },
};

// Linear Search (unsorted is fine)
var result = SearchHelper.LinearSearch(products, 5);
Console.WriteLine($"Linear Search: {(result != null ? result.ProductName : "Not found")}");

// Binary Search requires sorted array
var sorted = products.OrderBy(p => p.ProductId).ToArray();
result = SearchHelper.BinarySearch(sorted, 5);
Console.WriteLine($"Binary Search: {(result != null ? result.ProductName : "Not found")}");

/*
 * Time Complexity:
 *   Linear Search : O(n) — checks each element
 *   Binary Search : O(log n) — halves search space each step
 * Binary search is preferred for large sorted datasets.
 */
