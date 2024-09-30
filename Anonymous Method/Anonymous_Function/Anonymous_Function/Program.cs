using System;

class Test
{
    public static void Main()
    {
        List<Employee> list = new List<Employee>()
        {
            new Employee { Id = 10, Name = "Mark"},
            new Employee { Id = 11, Name = "John" },
            new Employee { Id = 12, Name = "Marry" },
        };
        //step 2
        //        Predicate<Employee> employeePredicate = new Predicate<Employee>(FindEmployee);

        //step 3

        Employee employee = list.Find(delegate(Employee emp)
        {
            return emp.Id == 11;
        });
        Console.WriteLine("Id = {0}, Name = {1}", employee.Id, employee.Name);

        //Employee employee = list.Find(emp => FindEmployee(emp));
        //Console.WriteLine("Id = {0}, Name = {1}", employee.Id, employee.Name); 
    }
    //step 1
    public static bool FindEmployee(Employee Emp)
    {
        return Emp.Id == 11;
    }
}

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
}