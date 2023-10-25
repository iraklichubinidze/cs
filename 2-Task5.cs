using System;
using System.Collections.Generic;

class MyCollection<T>
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public T GetItem(int index)
    {
        if (index >= 0 && index < items.Count)
        {
            return items[index];
        }
        throw new IndexOutOfRangeException("Index is out of range.");
    }
}

class Program
{
    static void Main()
    {
        MyCollection<string> stringCollection = new MyCollection<string>();

        stringCollection.AddItem("Apple");
        stringCollection.AddItem("Banana");
        stringCollection.AddItem("Cherry");

        Console.WriteLine("Item at index 0: " + stringCollection.GetItem(0));
        Console.WriteLine("Item at index 1: " + stringCollection.GetItem(1));
        Console.WriteLine("Item at index 2: " + stringCollection.GetItem(2));
    }
}