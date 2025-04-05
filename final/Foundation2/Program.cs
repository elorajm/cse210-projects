using System;
using System.Collections.Generic; // Required for List

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Order Processing System\n");

        // --- Create Addresses ---
        // Address within the USA
        Address address1 = new Address("123 Maple Street", "Anytown", "CA", "USA");
        // Another address within the USA
        Address address2 = new Address("456 Oak Avenue", "Springfield", "IL", "USA");
        // Address outside the USA
        Address address3 = new Address("789 Pine Crescent", "Toronto", "ON", "Canada");
        Address address4 = new Address("10 Downing Street", "London", "N/A", "UK"); // Example UK address

        // --- Create Customers ---
        Customer customer1 = new Customer("Alice Smith", address1); // USA customer
        Customer customer2 = new Customer("Bob Johnson", address3); // Canadian customer
        Customer customer3 = new Customer("Charlie Brown", address2); // USA customer
        Customer customer4 = new Customer("Diana Prince", address4); // UK customer


        // --- Create Products --- (Using decimal for prices)
        Product product1 = new Product("Laptop", "LP-1001", 1200.50m, 1);
        Product product2 = new Product("Mouse", "MS-2020", 25.99m, 2);
        Product product3 = new Product("Keyboard", "KB-305", 75.00m, 1);
        Product product4 = new Product("Webcam", "WC-450", 49.95m, 1);
        Product product5 = new Product("Monitor", "MN-700", 299.99m, 1);
        Product product6 = new Product("USB Cable", "UC-003", 9.50m, 3);
        Product product7 = new Product("Docking Station", "DS-999", 149.00m, 1);


        // --- Create Orders ---

        // Order 1: USA Customer, multiple products
        List<Product> productsOrder1 = new List<Product>()
        {
            product1, // Laptop
            product3, // Keyboard
            product6  // 3x USB Cable
        };
        Order order1 = new Order(productsOrder1, customer1);

        // Order 2: International Customer, different products
        List<Product> productsOrder2 = new List<Product>()
        {
            product5, // Monitor
            product2  // 2x Mouse
        };
        Order order2 = new Order(productsOrder2, customer2);

        // Order 3: Another USA Customer, single high-value item + accessory
        List<Product> productsOrder3 = new List<Product>()
        {
            product7, // Docking Station
            product4  // Webcam
        };
        Order order3 = new Order(productsOrder3, customer3);

        // Order 4: Another International Customer
         List<Product> productsOrder4 = new List<Product>()
        {
            product1, // Laptop
            product4, // Webcam
            product2 // 2x Mouse
        };
        Order order4 = new Order(productsOrder4, customer4);


        // --- Display Order Details ---

        Console.WriteLine("--- Order 1 Details ---");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Shipping Cost: {order1.GetShippingCost():C}"); // Display shipping cost
        Console.WriteLine($"Total Order Cost: {order1.CalculateTotalCost():C}\n"); // Use updated method name and currency format

        Console.WriteLine("--- Order 2 Details ---");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Shipping Cost: {order2.GetShippingCost():C}");
        Console.WriteLine($"Total Order Cost: {order2.CalculateTotalCost():C}\n");

        Console.WriteLine("--- Order 3 Details ---");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Shipping Cost: {order3.GetShippingCost():C}");
        Console.WriteLine($"Total Order Cost: {order3.CalculateTotalCost():C}\n");

        Console.WriteLine("--- Order 4 Details ---");
        Console.WriteLine(order4.GetPackingLabel());
        Console.WriteLine(order4.GetShippingLabel());
        Console.WriteLine($"Shipping Cost: {order4.GetShippingCost():C}");
        Console.WriteLine($"Total Order Cost: {order4.CalculateTotalCost():C}\n");


        Console.WriteLine("Processing complete.");
    }
}