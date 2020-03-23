using AbstractFactory.Chair;
using AbstractFactory.Sofa;

namespace AbstractFactory.Factory
{
    public interface IFurnitureFactory
    {
        ISofa CreateSofa();

        IChair CreateModern();
    }
}
