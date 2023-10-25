using System;

public class MyList<T>
{
    private T[] items;
    private int count;

    public MyList()
    {
        items = new T[10]; 
        count = 0;
    }

    public void Add(T item)
    {
        if (count >= items.Length)
        {
            Array.Resize(ref items, items.Length * 2); 
        }

        items[count] = item;
        count++;
    }

    public T Get(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new IndexOutOfRangeException("out of range.");
        }

        return items[index];
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyList<int> intList = new MyList<int>();
        intList.Add(10);
        intList.Add(20);
        intList.Add(30);
        Console.WriteLine("Element at index 0: " + intList.Get(0));
        Console.WriteLine("Element at index 1: " + intList.Get(1));
        Console.WriteLine("Element at index 2: " + intList.Get(2));

        try
        {
            int outOfRangeElement = intList.Get(3);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}