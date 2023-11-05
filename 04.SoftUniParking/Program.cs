using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> parkingDatabase = new Dictionary<string, string>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] commandArgs = Console.ReadLine().Split(' ');
            string command = commandArgs[0];
            string username = commandArgs[1];

            if (command == "register")
            {
                string licensePlateNumber = commandArgs[2];
                RegisterUser(parkingDatabase, username, licensePlateNumber);
            }
            else if (command == "unregister")
            {
                UnregisterUser(parkingDatabase, username);
            }
        }

        PrintRegisteredUsers(parkingDatabase);
    }

    static void RegisterUser(Dictionary<string, string> parkingDatabase, string username, string licensePlateNumber)
    {
        if (parkingDatabase.ContainsKey(username))
        {
            Console.WriteLine($"ERROR: already registered with plate number {parkingDatabase[username]}");
        }
        else
        {
            parkingDatabase[username] = licensePlateNumber;
            Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
        }
    }

    static void UnregisterUser(Dictionary<string, string> parkingDatabase, string username)
    {
        if (parkingDatabase.ContainsKey(username))
        {
            parkingDatabase.Remove(username);
            Console.WriteLine($"{username} unregistered successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: user {username} not found");
        }
    }

    static void PrintRegisteredUsers(Dictionary<string, string> parkingDatabase)
    {
        foreach (var entry in parkingDatabase)
        {
            Console.WriteLine($"{entry.Key} => {entry.Value}");
        }
    }
}
