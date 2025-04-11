using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        Square s1 = new Square("Teal", 9);
        shapes.Add(s1);
        Console.WriteLine($"Area: {s1.GetArea()}");
        Console.WriteLine($"Color: {s1.GetColor()}");
        Console.WriteLine();
        
        Rectangle r1 = new Rectangle("Forest Green", 5, 9);
        shapes.Add(r1);
        Console.WriteLine($"Area: {r1.GetArea()}");
        Console.WriteLine($"Color: {r1.GetColor()}");
        Console.WriteLine();

        Circle c1 = new Circle("Gold", 2);
        shapes.Add(c1);
        Console.WriteLine($"Area: {c1.GetArea()}");
        Console.WriteLine($"Color: {c1.GetColor()}");
        Console.WriteLine();
    }
}