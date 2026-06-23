Logger logger1 = Logger.GetInstance();
Logger logger2 = Logger.GetInstance();

logger1.Log("First log message");
logger2.Log("Second log message");

if (Object.ReferenceEquals(logger1, logger2))
    Console.WriteLine("Both are the same instance - Singleton works!");
else
    Console.WriteLine("Different instances - Singleton failed.");
