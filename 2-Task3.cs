using System;

class Item
{
    protected double Price;

    public Item()
    {
        Price = 0;
    }
}

class Fruit : Item
{
    private double _weightInKg;
    private double _priceOfOneKg;

    public double WeightInKg
    {
        get { return _weightInKg; }
        set { _weightInKg = value; }
    }

    public double PriceOfOneKg
    {
        get { return _priceOfOneKg; }
        set { _priceOfOneKg = value; }
    }

    public double CalculateTotalPrice(double weight, double priceOfOneKg)
    {
        return weight * priceOfOneKg;
    }
}

class Electronics : Item
{
    private int _quantity;
    private double _oneUnitPrice;

    public int Quantity
    {
        get { return _quantity; }
        set { _quantity = value; }
    }

    public double OneUnitPrice
    {
        get { return _oneUnitPrice; }
        set { _oneUnitPrice = value; }
    }

    public double CalculateTotalPrice()
    {
        return _quantity * _oneUnitPrice;
    }
}

class Program
{
    static void Main()
    {
        Fruit fruit = new Fruit();
        fruit.WeightInKg = 2.5;
        fruit.PriceOfOneKg = 3.0;
        double fruitTotalPrice = fruit.CalculateTotalPrice(fruit.WeightInKg, fruit.PriceOfOneKg);
        Console.WriteLine("Fruit Total Price: $" + fruitTotalPrice);

        Electronics electronics = new Electronics();
        electronics.Quantity = 5;
        electronics.OneUnitPrice = 100.0;
        double electronicsTotalPrice = electronics.CalculateTotalPrice();
        Console.WriteLine("Electronics Total Price: $" + electronicsTotalPrice);
    }
}