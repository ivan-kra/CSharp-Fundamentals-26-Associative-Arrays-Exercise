using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, Product> products = new Dictionary<string, Product>();

        string input = Console.ReadLine();

        while (input != "buy")
        {
            string[] tokens = input.Split(' ');
            string name = tokens[0];
            double price = double.Parse(tokens[1]);
            int quantity = int.Parse(tokens[2]);

            if (products.ContainsKey(name))
            {
                products[name].Price = price;
                products[name].Quantity += quantity;
            }
            else
            {
                products[name] = new Product { Price = price, Quantity = quantity };
            }

            input = Console.ReadLine();
        }

        foreach (var product in products)
        {
            double totalPrice = product.Value.Price * product.Value.Quantity;
            Console.WriteLine($"{product.Key} -> {totalPrice:f2}");
        }
    }
}

class Product
{
    public double Price { get; set; }
    public int Quantity { get; set; }
}