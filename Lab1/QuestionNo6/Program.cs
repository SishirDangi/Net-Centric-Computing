using System;

// Interface for shape
interface IShape
{
    double GetArea();
}

// Interface for rectangle
interface IRectangle
{
    double Length { get; set; }
    double Width { get; set; }
}

// Rectangle class implementing both interfaces
class Rectangle : IShape, IRectangle
{
    public double Length { get; set; }
    public double Width { get; set; }

    public double GetArea()
    {
        return Length * Width;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a rectangle object
        Rectangle rectangle = new Rectangle();

        // Set length and width of the rectangle
        rectangle.Length = 9;
        rectangle.Width = 6;

        // Calculate and display area of the rectangle
        double area = rectangle.GetArea();
        Console.WriteLine("Area of rectangle: " + area);
        Console.ReadLine();
    }
}
