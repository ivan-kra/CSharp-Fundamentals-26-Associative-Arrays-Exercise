using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, long> resources = new Dictionary<string, long>();

        string resource = Console.ReadLine();

        while (resource != "stop")
        {
            long quantity = long.Parse(Console.ReadLine());

            if (resources.ContainsKey(resource))
            {
                resources[resource] += quantity;
            }
            else
            {
                resources[resource] = quantity;
            }

            resource = Console.ReadLine();
        }

        foreach (var kvp in resources)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}