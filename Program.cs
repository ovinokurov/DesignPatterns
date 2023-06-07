using DesignPatterns;

public class Program
{
    private readonly Singleton singleton;

    public Program()
    {
        singleton = Singleton.Instance;
    }

    public void RunDependencyInjection(string emailAddress)
    {
        Console.WriteLine($"Hello, {GetUsername(emailAddress)}!");
    }

    private static string GetUsername(string emailAddress)
    {
        int atIndex = emailAddress.IndexOf('@');
        return (atIndex > 0) ? emailAddress.Substring(0, atIndex) : string.Empty;
    }

    static void Main()
    {
        // No Pattern
        Console.WriteLine("No Pattern");
        Console.WriteLine($"Hello, {GetUsername("Oleg@gmail.com")}!");

        // Singleton Pattern
        Console.WriteLine("Singleton Pattern");
        Singleton singleton = Singleton.Instance;
        Console.WriteLine($"Hello, {singleton.GetUsername("Oleg@gmail.com")}!");

        // Factory Pattern
        Console.WriteLine("Factory Pattern");
        ProductFactory factory = new ProductFactory();
        IProduct product = factory.CreateProduct();
        Console.WriteLine($"Hello, {product.GetUsername("Oleg@gmail.com")}!");

        // Observer Pattern
        Console.WriteLine("Observer Pattern");
        Observer observer = new Observer();
        singleton.Attach(observer);
        singleton.NotifyObservers("Oleg@gmail.com");
        string username = observer.GetUsername();
        Console.WriteLine($"Hello, {username}!");

        // Dependency Injection (Injection Pattern)
        Console.WriteLine("Dependency Injection Pattern");
        Program program = new Program();
        program.RunDependencyInjection("Oleg@gmail.com");

        // Other methods and code...
        singleton.Detach(observer);
    }
}
