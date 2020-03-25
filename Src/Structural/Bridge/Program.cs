using Bridge.Colors;
using Bridge.Shapes;
using System;

namespace Bridge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shape abstraction;
            abstraction = new Shape(new Red());
            Console.Write(abstraction.Operation());

            Console.WriteLine();

            abstraction = new Circle(new Blue());
            Console.Write(abstraction.Operation());
        }
    }
}