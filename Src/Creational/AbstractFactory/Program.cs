using AbstractFactory.Factory;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client: Testing client code with the first factory type modern furniture");
            ClientMethod(new ModernFurnitureFactory());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type victorian furniture");
            ClientMethod(new VictorianFurnitureFactory());
        }

        public static void ClientMethod(IFurnitureFactory factory)
        {
            var sofa = factory.CreateSofa();
            var modern = factory.CreateModern();

            Console.WriteLine(sofa.Print());
            Console.WriteLine(modern.Print());
        }
    }
}
