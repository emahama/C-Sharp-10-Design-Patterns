
using Singleton;

Console.Title = "Singletion Examplet";
var instance1 = Logger.Instance;
var instance2 = Logger.Instance;

if (instance1 == instance2)
{
    Console.WriteLine($"{nameof(instance1)} and {nameof(instance2)} are the same");
}

instance1?.Log($"Logging from {nameof(instance1)}");
instance2?.Log($"Logging from {nameof(instance2)}");
Console.WriteLine($"Logging from {nameof(Logger.Instance)}");
