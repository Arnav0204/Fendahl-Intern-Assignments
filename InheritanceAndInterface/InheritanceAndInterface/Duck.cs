using System;

public interface IFly
{
    void Fly();
}

public interface ISwim
{
    void Swim();
}

public class Duck : IFly, ISwim
{
    public void Fly()
    {
        Console.WriteLine("Duck is flying.");
    }

    public void Swim()
    {
        Console.WriteLine("Duck is swimming.");
    }
}
