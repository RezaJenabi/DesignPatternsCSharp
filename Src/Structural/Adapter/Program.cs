using Adapter.Models;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            IRailAdapter railAdapter = new RailAdapter(car);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(railAdapter.Move());
        }
    }
}