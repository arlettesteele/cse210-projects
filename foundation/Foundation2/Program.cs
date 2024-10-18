using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var address1 = new Address("1815 Canyon Rd", "Springville", "UT", "USA");
        var address2 = new Address("555 W Mikan Dr", "Rexburg", "ID", "USA");

        var customer1 = new Customer("Collin Steele", address1);
        var customer2 = new Customer("Carolina Encina", address2);

        var product1 = new Product("Laptop", "A001", 1200.00, 1);
        var product2 = new Product("Mouse", "B002", 25.50, 2);
        var product3 = new Product("Keyboard", "C003", 80.00, 1);
        var product4 = new Product("Monitor", "D004", 300.00, 1);

        var order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        var order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine(order1.GetPackageLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order1.GetTotal():C}\n");

        Console.WriteLine(order2.GetPackageLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order2.GetTotal():C}");
    }

}