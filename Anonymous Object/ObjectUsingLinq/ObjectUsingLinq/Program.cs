using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args)
    {
        // List of objects
        var employees = new List<Employee>
        {
            new Employee { Name = "Alice", Age = 28 },
            new Employee { Name = "Bob", Age = 35 },
            new Employee { Name = "Charlie", Age = 22 }
        };

        // Use LINQ query with anonymous objects and Func delegate
        Func<Employee, object> projection = e => new { e.Name, e.Age };

        var youngEmployees = employees.Where(e => e.Age < 30)
                                      .Select(projection);

        // Print the results
        foreach (var emp in youngEmployees)
        {
            Console.WriteLine($"Name: {emp.Name}, Age: {emp.Age}");
        }
    }
}

public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
}
