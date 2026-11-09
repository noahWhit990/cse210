using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("red", 2));
        shapes.Add(new Rectangle("green", 3, 4));
        shapes.Add(new Circle("blue", 3));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
        }
    }
}