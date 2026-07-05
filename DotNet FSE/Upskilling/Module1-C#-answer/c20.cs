using System;
using System.Collections.Generic;
using System.Linq;

class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public double TotalAmount { get; set; }
}

class Program
{
    static void Main()
    {
        List<Order> orders = new List<Order>
        {
            new Order { OrderId = 1, CustomerName = "Aryan", TotalAmount = 5000 },
            new Order { OrderId = 2, CustomerName = "Rahul", TotalAmount = 2000 },
            new Order { OrderId = 3, CustomerName = "Amit", TotalAmount = 7000 }
        };

        var result = orders
            .Where(o => o.TotalAmount > 3000)
            .Select(o => new
            {
                o.OrderId,
                o.CustomerName
            });

        foreach (var order in result)
        {
            Console.WriteLine(order.OrderId + " " + order.CustomerName);
        }
    }
}