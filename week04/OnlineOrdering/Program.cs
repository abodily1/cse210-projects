using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order("Jake", "5965 Drive", "Denver", "CO", "USA");
        order1.AddProduct("Apple","1234", 2.50, 1);
        order1.AddProduct("Banana","5678", 2.50, 6);

        Console.WriteLine($"The total cost of the order is: ${order1.ComputeCost():F2}");
        Console.WriteLine($"Items ordered: ");
        order1.GetPackingLabel();
        order1.GetShippingLabel();

        Console.WriteLine();

        Order order2 = new Order("Jack", "4352 Road", "Rome", "Rome", "Italy");
        order2.AddProduct("Pear","4321", 1.27, 2);
        order2.AddProduct("Noodles","8765", 6.25, 3);

        Console.WriteLine($"The total cost of the order is: ${order2.ComputeCost():F2}");
        Console.WriteLine($"Items ordered: ");
        order2.GetPackingLabel();
        order2.GetShippingLabel();
    }
}