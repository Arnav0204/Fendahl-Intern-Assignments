using System;

public abstract class Vehicle
{
    public string LicensePlate { get; set; }
    public int MaxSpeed { get; set; }

    public void StartEngine()
    {
        Console.WriteLine("Engine started.");
    }

    public abstract void DisplayDetails();
}

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Car: {LicensePlate}, Max Speed: {MaxSpeed}, Doors: {NumberOfDoors}");
    }
}

public class Motorbike : Vehicle
{
    public bool HasSideCar { get; set; }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Motorbike: {LicensePlate}, Max Speed: {MaxSpeed}, SideCar: {HasSideCar}");
    }
}

public class Bicycle : Vehicle
{
    public bool IsElectric { get; set; }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Bicycle: {LicensePlate}, Max Speed: {MaxSpeed}, Electric: {IsElectric}");
    }
}
