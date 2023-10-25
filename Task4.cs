using System;

public abstract class Vehicle
{
    public abstract string StartEngine();
}
public class Car : Vehicle
{
    public override string StartEngine()
    {
        return "Car engine started";
    }
}
public class Bicycle : Vehicle
{
    public override string StartEngine()
    {
        return "Pedaling the bicycle";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vehicle car = new Car();
        Vehicle bicycle = new Bicycle();

        Console.WriteLine("Car: " + car.StartEngine());
        Console.WriteLine("Bicycle: " + bicycle.StartEngine());
    }
}