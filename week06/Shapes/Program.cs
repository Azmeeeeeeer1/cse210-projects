using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Square square = new Square("red", 30);

        Rectangle rectangle = new Rectangle("Blue", 8, 5);

        Circle circle = new Circle("Purple", 5.5);


        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The color of the shape is: {color}");
            Console.WriteLine($"The Area of the shape is: {area}");
            Console.WriteLine("______________________________________");
        }
    }
}