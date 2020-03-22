using System;
using FactoryMethod.Car;
using FactoryMethod.Factory;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar ferrari = CarFactory.Car(CarsBrand.Ferrari);
            Console.WriteLine(ferrari.ToString());

            ICar ford = CarFactory.Car(CarsBrand.Ford);
            Console.WriteLine(ford.ToString());

            Console.ReadKey();

        }
    }
}
