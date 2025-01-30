using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Laptop", 101, 800.00, 1);
        Product product2 = new Product("Headphones", 102, 100.00, 2);
        Product product3 = new Product("Mouse", 103, 25.00, 3);

        Address address1 = new Address("123 Elm St", "SpringField", "IL", "USA");
        Address address2 = new Address("456 Oak St", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("Aaron Stoor", address1);
        Customer customer2 = new Customer("Jeffrey Jefferson", address2);

        List<Product> productsForOrder1 = new List<Product> { product1, product2 };
        Order order1 = new Order(productsForOrder1, customer1);

        List<Product> productsForOrder2 = new List<Product> { product2, product3 };
        Order order2 = new Order(productsForOrder2, customer2);

        Console.WriteLine("Order 1:");
        Console.WriteLine($"Total Cost: ${order1.TotalCost():0.00}");
        Console.WriteLine("\nPacking Label:\n" + order1.PackingLabel());
        Console.WriteLine("\nShipping Label:\n" + order1.ShippingLabel());
        Console.WriteLine();

        Console.WriteLine("Order2: ");
        Console.WriteLine($"Total Cost: ${order2.TotalCost():0.00}");
        Console.WriteLine("\nPacking Label:\n" + order2.PackingLabel());
        Console.WriteLine("\nShipping Label:\n" + order2.ShippingLabel());
    }
}