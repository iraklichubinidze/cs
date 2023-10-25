using System;

class Employee
{
    private string _employeeName;
    public string Salary { get; set; }

    public Employee(string name, string salary)
    {
        _employeeName = name;
        Salary = salary;
    }

    public string DisplayInfo()
    {
        return $"Hi, I'm {_employeeName} and I earn {Salary} per year.";
    }
}

class Program
{
    static void Main()
    {
        Employee employee = new Employee("John Doe", "$50,000");
        string info = employee.DisplayInfo();
        Console.WriteLine(info);
    }
}