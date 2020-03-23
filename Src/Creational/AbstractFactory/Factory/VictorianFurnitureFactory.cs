using AbstractFactory.Chair;
using AbstractFactory.Sofa;

namespace AbstractFactory.Factory
{
    class VictorianFurnitureFactory : IFurnitureFactory
    {
        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }

        public IChair CreateModern()
        {
            return new VictorianChair();
        }
    }
}
