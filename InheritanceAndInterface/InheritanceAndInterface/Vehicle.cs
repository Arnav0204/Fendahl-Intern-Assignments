using System;

public class Vehicle
{
    public void StartEngine()
    {
        Console.WriteLine("Engine started.");
    }
}

public class Car : Vehicle
{
    public void Drive()
    {
        Console.WriteLine("Car is driving.");
    }
}

public class ElectricCar : Car
{
    public void ChargeBattery()
    {
        Console.WriteLine("Battery charging.");
    }
}
