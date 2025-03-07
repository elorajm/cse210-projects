using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Black", 10.1);
        Circle circle =  new Circle(10.2, "blue");
        Rectangle rectangle = new Rectangle(10.3, 5.4, "Red");
        List<Shape> shapes = new List<Shape>();
        
        shapes.Add(rectangle);
        shapes.Add(circle);
        shapes.Add(square);
        foreach (Shape shape in shapes){
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
        }

    }
}