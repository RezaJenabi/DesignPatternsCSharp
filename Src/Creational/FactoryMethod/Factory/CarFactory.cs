using System;
using System.Linq;
using FactoryMethod.Car;

namespace FactoryMethod.Factory
{
    public class CarFactory
    {
        public static ICar Car(CarsBrand carsBrand)
        {
            var car = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
                .Where(x => typeof(ICar).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                .FirstOrDefault(x => x.Name.ToLower() == carsBrand.ToString().ToLower());

            return Activator.CreateInstance(car) as ICar;
        }
    }
}
