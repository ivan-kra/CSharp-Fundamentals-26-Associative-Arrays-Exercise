using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

        string input = Console.ReadLine();

        while (input != "End")
        {
            string[] inputArgs = input.Split(" -> ");
            string companyName = inputArgs[0];
            string employeeId = inputArgs[1];

            if (!companies.ContainsKey(companyName))
            {
                companies[companyName] = new List<string>();
            }

            if (!companies[companyName].Contains(employeeId))
            {
                companies[companyName].Add(employeeId);
            }

            input = Console.ReadLine();
        }

        foreach (var company in companies)
        {
            Console.WriteLine(company.Key);
            foreach (var employeeId in company.Value)
            {
                Console.WriteLine($"-- {employeeId}");
            }
        }
    }
}