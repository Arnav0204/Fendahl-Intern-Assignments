using System;

public abstract class Employee
{
    public string Name { get; set; }
    public int EmployeeID { get; set; }
    public decimal Salary { get; set; }

    public abstract void DisplayRole();
}

public class Manager : Employee
{
    public void ManageTeam()
    {
        Console.WriteLine($"{Name} is managing the team.");
    }

    public override void DisplayRole()
    {
        Console.WriteLine($"Manager: {Name}, ID: {EmployeeID}");
    }
}

public class Engineer : Employee
{
    public override void DisplayRole()
    {
        Console.WriteLine($"Engineer: {Name}, ID: {EmployeeID}");
    }
}

public class Intern : Employee
{
    public override void DisplayRole()
    {
        Console.WriteLine($"Intern: {Name}, ID: {EmployeeID}");
    }
}
