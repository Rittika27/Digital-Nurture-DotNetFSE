Logger logger1 = Logger.GetInstance();
Logger logger2 = Logger.GetInstance();

logger1.Log("Singleton Pattern Working");

Console.WriteLine(Object.ReferenceEquals(logger1, logger2));