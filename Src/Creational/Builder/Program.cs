using System;
using System.Collections.Generic;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var sportBuilder = new SportBuilder();
            director.Builder = sportBuilder;

            Console.WriteLine("Standard Sport Car:");
            director.MakeSportCar();
            Console.WriteLine(sportBuilder.GetCar().ToString());

            var sUVBuilder = new SUVBuilder();
            director.Builder = sUVBuilder;

            Console.WriteLine("\nStandard Suv Car:");
            director.MakeSuvCar();
            Console.WriteLine(sUVBuilder.GetCar().ToString());

        }
    }
}