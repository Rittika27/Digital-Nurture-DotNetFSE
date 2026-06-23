StockMarket market = new();
MobileApp mobile = new();
WebApp web = new();

market.Register(mobile);
market.Register(web);

market.SetPrice("AAPL", 189.50);
market.SetPrice("GOOGL", 140.20);

Console.WriteLine("\nDeregistering WebApp...");
market.Deregister(web);
market.SetPrice("MSFT", 420.00);
