using System;

namespace Prototype
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SetName("Reza");
            person.Address = new Address("Tehran");

            Console.WriteLine($"Person {person.ToString()}");

            Person personShallowCopy = person.ShallowCopy();
            Person personDeepCopy = person.DeepCopy();

            person.SetName("Amin");
            person.Address.SetStreet("Mazandaran");

            Console.WriteLine("\nPerson change ... ");
            Console.WriteLine($"\nPerson: {person.ToString()}");
            Console.WriteLine($"\nPerson Shallow Copy: {personShallowCopy.ToString()}");
            Console.WriteLine($"\nPerson Deep Copy: {personDeepCopy.ToString()}");
        }
    }
}
