
using System;
public delegate void DisplayDelegate();

public class Program
{
    public static void Main(string[] args)
    {
        var person = new
        {
            Name = "John",
            Age = 25
        };

        // Anonymous Method 
        //DisplayDelegate displayInfo = delegate ()
        //{
        //    // Access the anonymous object within the anonymous method
        //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        //};


        DisplayDelegate displayInfo = () =>
        {

            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        };


        displayInfo();
    }
}
