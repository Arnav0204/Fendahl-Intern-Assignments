using System;

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
}

public class Student
{
    public string Name { get; set; }
    public int RollNumber { get; set; }
    public Address Address { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Student: {Name}, Roll: {RollNumber}");
        Console.WriteLine($"Address: {Address.Street}, {Address.City}, {Address.State} - {Address.PostalCode}");
    }
}
