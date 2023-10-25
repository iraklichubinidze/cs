using System;

class Shape
{
    protected double Area;
    public Shape()
    {
        Area = 0;
    }
    public virtual void CalculateArea()
    {
        Console.WriteLine("Area is not defined for this shape.");
    }
}

class Rectangle : Shape
{
    private double _length;
    private double _width;

    public double Length
    {
        get { return _length; }
        set { _length = value; }
    }

    public double Width
    {
        get { return _width; }
        set { _width = value; }
    }

    public override void CalculateArea()
    {
        Area = _length * _width;
        Console.WriteLine("Rectangle Area: " + Area);
    }
}

class Circle : Shape
{
    private double _radius;

    public double Radius
    {
        get { return _radius; }
        set { _radius = value; }
    }

    public override void CalculateArea()
    {
        Area = Math.PI * _radius * _radius;
        Console.WriteLine("Circle Area: " + Area);
    }
}

class Program
{
    static void Main()
    {
        Rectangle rectangle = new Rectangle();
        rectangle.Length = 5.0;
        rectangle.Width = 3.0;
        rectangle.CalculateArea();

        Circle circle = new Circle();
        circle.Radius = 4.0;
        circle.CalculateArea();
    }
}