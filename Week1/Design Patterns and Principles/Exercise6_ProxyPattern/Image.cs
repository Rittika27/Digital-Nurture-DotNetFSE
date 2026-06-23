public interface IImage
{
    void Display();
}

public class RealImage : IImage
{
    private readonly string _filename;

    public RealImage(string filename)
    {
        _filename = filename;
        Console.WriteLine($"Loading image from remote server: {_filename}");
    }

    public void Display() => Console.WriteLine($"Displaying: {_filename}");
}

public class ProxyImage : IImage
{
    private readonly string _filename;
    private RealImage? _realImage;

    public ProxyImage(string filename) => _filename = filename;

    public void Display()
    {
        _realImage ??= new RealImage(_filename); // lazy init + cache
        _realImage.Display();
    }
}
