Book[] books =
{
    new Book { BookId = 1, Title = "Clean Code",          Author = "Robert Martin" },
    new Book { BookId = 2, Title = "Design Patterns",     Author = "Gang of Four"  },
    new Book { BookId = 3, Title = "The Pragmatic Programmer", Author = "Hunt & Thomas" },
    new Book { BookId = 4, Title = "Refactoring",         Author = "Martin Fowler" },
};

var result = LibrarySearch.LinearSearch(books, "Design Patterns");
Console.WriteLine($"Linear Search: {result}");

var sorted = books.OrderBy(b => b.Title).ToArray();
result = LibrarySearch.BinarySearch(sorted, "Design Patterns");
Console.WriteLine($"Binary Search: {result}");

/*
 * Time Complexity:
 *   Linear Search : O(n) — works on unsorted data
 *   Binary Search : O(log n) — requires sorted data, faster for large datasets
 */
