using System;

class Program
{
    static void Main(string[] args)
    {
        
        Address address = new Address("440 west","Rexburg","Idaho","US");
        Customer customer = new Customer("Jade",address);
        DateTime date = new DateTime(2025, 11, 16, 12, 30, 45);
        
        List<Product> products1 = new List<Product>()
        {
            new Product("apple", "A123", 10, 3),
            new Product("milk", "M456", 13, 1)
        };
        
        Order order1 = new Order(products1, customer);
        
        Console.WriteLine(date.ToString("g"));
        Console.WriteLine($"products name:{order1.p_label()}");
        Console.WriteLine(order1.s_label());
        Console.WriteLine($"{order1.total():C}\n");

    }
}