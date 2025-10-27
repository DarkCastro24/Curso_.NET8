// See https://aka.ms/new-console-template for more information

class Program()
{
    static void Main()
    {
        int quantity = 5;
        string message = "Hello, World!";
        decimal price = 19.99m;
        Console.WriteLine($"Message: {message}, Quantity: {quantity}, Price: {price:C}");
        // Declaracion con var 
        // Adivina el tipo de dato
        var greeting = "Hola"; // infiere que es string
        var porcentage = 99.9; // infiere que es double
        Console.WriteLine($"Greeting: {greeting}, Porcentage: {porcentage}");
    }
}