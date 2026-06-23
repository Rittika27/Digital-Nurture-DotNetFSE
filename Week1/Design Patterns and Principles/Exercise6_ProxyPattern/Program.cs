IImage image = new ProxyImage("photo.jpg");

Console.WriteLine("First call (loads from server):");
image.Display();

Console.WriteLine("\nSecond call (uses cache):");
image.Display();
