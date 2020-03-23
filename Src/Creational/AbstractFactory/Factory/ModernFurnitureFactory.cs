using AbstractFactory.Chair;
using AbstractFactory.Sofa;

namespace AbstractFactory.Factory
{
    class ModernFurnitureFactory : IFurnitureFactory
    {
        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }

        public IChair CreateModern()
        {
            return new ModernChair();
        }
    }
}
