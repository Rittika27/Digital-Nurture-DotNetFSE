Product[] products = new Product[]
{
    new Product { ProductId = 1, ProductName = "T-Shirt", Category = "Clothing" },
    new Product { ProductId = 3, ProductName = "Laptop", Category = "Electronics" },
    new Product { ProductId = 5, ProductName = "Shoes", Category = "Footwear" },
    new Product { ProductId = 7, ProductName = "Phone", Category = "Electronics" },
    new Product { ProductId = 9, ProductName = "Watch", Category = "Accessories" }
};

int searchId = 5;

Product result = SearchHelper.LinearSearch(products, searchId);
if (result != null)
    Console.WriteLine("Linear Search Found: " + result.ProductName);
else
    Console.WriteLine("Product not found.");

Product result2 = SearchHelper.BinarySearch(products, searchId);
if (result2 != null)
    Console.WriteLine("Binary Search Found: " + result2.ProductName);
else
    Console.WriteLine("Product not found.");
