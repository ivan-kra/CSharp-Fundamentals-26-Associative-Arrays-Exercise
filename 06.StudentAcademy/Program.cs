using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

        for (int i = 0; i < n; i++)
        {
            string studentName = Console.ReadLine();
            double grade = double.Parse(Console.ReadLine());

            if (!students.ContainsKey(studentName))
            {
                students[studentName] = new List<double>();
            }

            students[studentName].Add(grade);
        }

        foreach (var student in students.Where(s => s.Value.Average() >= 4.50))
        {
            double averageGrade = student.Value.Average();
            Console.WriteLine($"{student.Key} -> {averageGrade:f2}");
        }
    }
}