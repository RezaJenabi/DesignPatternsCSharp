using System;
using System.Collections.Generic;
using Specification.Mobiles;
using Specification.MobilesSpecification;
using Type = Specification.Mobiles.Type;

namespace Specification
{
    class Program
    {
        static void Main(string[] args)
        {
            var mobiles = new List<Mobile> {
                    new Mobile(BrandName.Samsung, Type.Smart),
                    new Mobile(BrandName.Apple, Type.Smart),
                    new Mobile(BrandName.Htc, Type.Basic),
                    new Mobile(BrandName.Samsung, Type.Basic)
            };

            var samsung = mobiles.FindAll(x => new SamsungBrandNameSpecification().IsSatisfiedBy(x));
            Console.WriteLine("BrandName Samsung:");
            var i = 1;
            samsung.ForEach(x =>
            {
                Console.WriteLine($"{i++}: {x.BrandName}, {x.Type}");
            });

            var samsungAndSmart = mobiles.FindAll(x => new SamsungBrandNameSpecification().And(new TypeSmartSpecification()).IsSatisfiedBy(x));
            Console.WriteLine($"\nBrandName Samsung And Type Smart:");
            i = 1;
            samsungAndSmart.ForEach(x =>
            {
                Console.WriteLine($"{i++}: {x.BrandName}, {x.Type}");
            });

            Console.ReadKey();
        }
    }
}
