﻿namespace FactoryMethod.Car
{
    public class Ferrari : ICar
    {
        public string GetPrice()
        {
            return "Base Ferrari Price: $252,800";
        }

        public override string ToString()
        {
            return "Type: Ferrari";
        }
    }
}
