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
Console.WriteLine($"Hello, {Singleton.Instance.GetUsername("Oleg@gmail.com")}!");

//Factory Pattern
ProductFactory factory = new ProductFactory();
IProduct product = factory.CreateProduct();
Console.WriteLine("Factory Pattern");
Console.WriteLine($"Hello, {product.GetUsername("Oleg@gmail.com")}!");