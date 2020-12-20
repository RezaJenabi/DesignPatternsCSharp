using Decorator.Models;
using System;

namespace Decorator
{

    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            var simple = new ConcreteComponent();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(simple);
            Console.WriteLine();

            Console.WriteLine("Client: Now I've got a decorated component (Uppercase):");
            ConcreteUppercaseDecorator uppercaseDecorator = new ConcreteUppercaseDecorator(simple);
            client.ClientCode(uppercaseDecorator);
            Console.WriteLine();

            ConcreteLowercaseDecorator lowercaseDecorator = new ConcreteLowercaseDecorator(uppercaseDecorator);
            Console.WriteLine("Client: Now I've got a decorated component (Lowercase):");
            client.ClientCode(lowercaseDecorator);
            Console.WriteLine();

        }
    }
}
