Inventory inventory = new();

inventory.Add(new Product { ProductId = 1, ProductName = "Laptop",  Quantity = 10, Price = 999.99 });
inventory.Add(new Product { ProductId = 2, ProductName = "Mouse",   Quantity = 50, Price = 29.99  });
inventory.Add(new Product { ProductId = 3, ProductName = "Monitor", Quantity = 15, Price = 299.99 });

Console.WriteLine("\n-- Inventory --");
inventory.Display();

inventory.Update(2, 40, 24.99);
inventory.Delete(3);

Console.WriteLine("\n-- Updated Inventory --");
inventory.Display();

/*
 * Time Complexity using Dictionary (HashMap):
 *   Add    : O(1)
 *   Update : O(1)
 *   Delete : O(1)
 * Dictionary provides constant time for all operations via hashing.
 */
