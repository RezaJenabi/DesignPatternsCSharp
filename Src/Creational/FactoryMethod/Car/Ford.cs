namespace FactoryMethod.Car
{
    public class Ford : ICar
    {
        public string GetPrice()
        {
            return "2020 MUSTANG Starting at $35,630";
        }

        public override string ToString()
        {
            return "Type: Ford";
        }
    }
}
