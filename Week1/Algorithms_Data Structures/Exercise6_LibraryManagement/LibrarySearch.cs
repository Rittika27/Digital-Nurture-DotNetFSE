public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;

    public override string ToString() => $"[{BookId}] \"{Title}\" by {Author}";
}

public static class LibrarySearch
{
    // O(n)
    public static Book? LinearSearch(Book[] books, string title)
    {
        foreach (var b in books)
            if (b.Title.Equals(title, StringComparison.OrdinalIgnoreCase)) return b;
        return null;
    }

    // O(log n) — books must be sorted by Title
    public static Book? BinarySearch(Book[] books, string title)
    {
        int low = 0, high = books.Length - 1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            int cmp = string.Compare(books[mid].Title, title, StringComparison.OrdinalIgnoreCase);
            if (cmp == 0) return books[mid];
            else if (cmp < 0) low = mid + 1;
            else high = mid - 1;
        }
        return null;
    }
}
