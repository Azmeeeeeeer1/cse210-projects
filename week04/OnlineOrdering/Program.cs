using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA");

        Customer customer1 = new Customer("John Smith", address1);

        List<Product> products1 = new List<Product>()
        {
            new Product("Laptop", "P100", 850.00, 1),
            new Product("Mouse", "P101", 25.50, 2),
            new Product("Keyboard", "P102", 40.00, 1)
        };

        Order order1 = new Order(customer1, products1);

        // Second customer (International)
        Address address2 = new Address(
            "45 Queen Street",
            "Toronto",
            "Ontario",
            "Canada");

        Customer customer2 = new Customer("Emma Wilson", address2);

        List<Product> products2 = new List<Product>()
        {
            new Product("Phone", "P200", 600.00, 1),
            new Product("Phone Case", "P201", 20.00, 2)
        };

        Order order2 = new Order(customer2, products2);

        DisplayOrder(order1);

        Console.WriteLine("----------------------------------------");

        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine("PACKING LABEL");
        Console.WriteLine(order.GetPackingLabel());

        Console.WriteLine();

        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine();

        Console.WriteLine($"Total Price: ${order.CalculateTotalCost():F2}");
        Console.WriteLine();
    }
}