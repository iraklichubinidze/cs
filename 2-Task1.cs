using System;

class Program
{
    static void Main(string[] args)
    {
        int quantity = 7;
        string itemName = "Widget";

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Product: {itemName}, Index: {i}");
        }
    }
}