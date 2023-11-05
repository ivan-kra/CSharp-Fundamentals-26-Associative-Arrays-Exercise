using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

        string input = Console.ReadLine();

        while (input != "end")
        {
            string[] inputArgs = input.Split(" : ");
            string courseName = inputArgs[0];
            string studentName = inputArgs[1];

            if (!courses.ContainsKey(courseName))
            {
                courses[courseName] = new List<string>();
            }

            courses[courseName].Add(studentName);

            input = Console.ReadLine();
        }

        foreach (var course in courses)
        {
            Console.WriteLine($"{course.Key}: {course.Value.Count}");
            foreach (var student in course.Value)
            {
                Console.WriteLine($"-- {student}");
            }
        }
    }
}