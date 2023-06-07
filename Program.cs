using DesignPatterns;

//No Pattern 
Console.WriteLine("No Pattern");
Console.WriteLine($"Hello, {GetUsername("Oleg@gmail.com")}!");

static string GetUsername(string emailAddress)
{
    int atIndex = emailAddress.IndexOf('@');
    return (atIndex > 0) ? emailAddress.Substring(0, atIndex) : string.Empty;
}

//Singleton Pattern
Console.WriteLine("Singleton Pattern");
Singleton singleton = Singleton.Instance;
Console.WriteLine($"Hello, {Singleton.Instance.GetUsername("Oleg@gmail.com")}!");


//Factory Pattern
ProductFactory factory = new ProductFactory();
IProduct product = factory.CreateProduct();
Console.WriteLine("Factory Pattern");
Console.WriteLine($"Hello, {product.GetUsername("Oleg@gmail.com")}!");


// Observer Pattern
Console.WriteLine("Observer Pattern");
Observer observer = new Observer();
singleton.Attach(observer);
singleton.NotifyObservers("Oleg@gmail.com");
string username = observer.GetUsername();
Console.WriteLine($"Hello, {username}!");

// Other methods and code...

singleton.Detach(observer);