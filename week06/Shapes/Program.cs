using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("blue", 14));
        shapes.Add(new Rectangle("blue", 4, 7));
        shapes.Add(new Circle("blue", 5));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}