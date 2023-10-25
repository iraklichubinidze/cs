using System;

abstract class Bird
{
    public abstract string MakeSound();
}

class Sparrow : Bird
{
    public override string MakeSound()
    {
        return "Chirp";
    }
}

class Pigeon : Bird
{
    public override string MakeSound()
    {
        return "Coo";
    }
}

class Program
{
    static void Main()
    {
        Bird sparrow = new Sparrow();
        Bird pigeon = new Pigeon();

        Console.WriteLine("Sparrow makes the sound: " + sparrow.MakeSound());
        Console.WriteLine("Pigeon makes the sound: " + pigeon.MakeSound());
    }
}