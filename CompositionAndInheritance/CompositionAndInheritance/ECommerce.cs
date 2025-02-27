using System;

public class Supplier
{
    public string Name { get; set; }
    public string ContactDetails { get; set; }
}

public abstract class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string SKU { get; set; }
    public Supplier Supplier { get; set; }

    public abstract void DisplayProduct();
}

public class Electronics : Product
{
    public int WarrantyPeriod { get; set; }

    public override void DisplayProduct()
    {
        Console.WriteLine($"Electronics: {Name}, Price: {Price}, Warranty: {WarrantyPeriod} years");
    }
}

public class Clothing : Product
{
    public string Size { get; set; }

    public override void DisplayProduct()
    {
        Console.WriteLine($"Clothing: {Name}, Price: {Price}, Size: {Size}");
    }
}

public class Groceries : Product
{
    public DateTime ExpirationDate { get; set; }

    public override void DisplayProduct()
    {
        Console.WriteLine($"Groceries: {Name}, Price: {Price}, Expires on: {ExpirationDate.ToShortDateString()}");
    }
}
