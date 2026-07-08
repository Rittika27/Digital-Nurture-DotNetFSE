using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;
using RetailInventory.Models;

using var context = new AppDbContext();

Console.WriteLine("===== Retail Inventory System =====");

// Lab 4 - Insert data if database is empty
if (!context.Categories.Any())
{
    var electronics = new Category
    {
        Name = "Electronics"
    };

    var groceries = new Category
    {
        Name = "Groceries"
    };

    await context.Categories.AddRangeAsync(electronics, groceries);

    var product1 = new Product
    {
        Name = "Laptop",
        Price = 75000,
        Category = electronics
    };

    var product2 = new Product
    {
        Name = "Rice Bag",
        Price = 1200,
        Category = groceries
    };

    await context.Products.AddRangeAsync(product1, product2);

    await context.SaveChangesAsync();

    Console.WriteLine("Sample data inserted.");
}
else
{
    Console.WriteLine("Sample data already exists.");
}

// Lab 5 - Retrieve data

Console.WriteLine("\nAll Products");

var products = await context.Products
    .Include(p => p.Category)
    .ToListAsync();

foreach (var product in products)
{
    Console.WriteLine($"{product.Name} - ₹{product.Price} ({product.Category.Name})");
}

var found = await context.Products.FindAsync(1);

if (found != null)
{
    Console.WriteLine($"\nFound Product: {found.Name}");
}

var expensive = await context.Products
    .FirstOrDefaultAsync(p => p.Price > 50000);

if (expensive != null)
{
    Console.WriteLine($"Expensive Product: {expensive.Name}");
}