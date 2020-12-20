using System;

namespace Decorator.Models
{
    public class Client
    {
        public void ClientCode(IComponent component)
        {
            Console.WriteLine("RESULT: " + component.GetInfo());
        }
    }
}
