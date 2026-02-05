using System;
class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        Product product1 = new Product("Laptop", "L123", 1000, 1);
        Product product2 = new Product("Mouse", "M456", 25, 2);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        Console.WriteLine(" ");
        Console.WriteLine("Order 1 (USA Customer)");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);
        Product product3 = new Product("Smartphone", "S789", 800, 1);
        Product product4 = new Product("Case", "C012", 20, 1);
        Product product5 = new Product("Charger", "CH34", 15, 3);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        Console.WriteLine("");
        Console.WriteLine("Order 2 (International Customer)");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
        Console.WriteLine("");
    }
}