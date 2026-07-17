using Singleton_DesignPattern;


Logger logger1 = Logger.GetInstance();
Logger logger2 = Logger.GetInstance();
Logger logger3 = Logger.GetInstance();

logger1.Log("Maintenance Started");
logger2.Log("Maintenance Completed");
logger3.Log("Report Uploaded");

Console.WriteLine();

Console.WriteLine($"logger1 HashCode : {logger1.GetHashCode()}");
Console.WriteLine($"logger2 HashCode : {logger2.GetHashCode()}");
Console.WriteLine($"logger3 HashCode : {logger3.GetHashCode()}");