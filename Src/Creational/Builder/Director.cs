namespace Builder
{
    public class Director
    {
        private ICarBuilder _builder;

        public ICarBuilder Builder
        {
            set { _builder = value; }
        }

        public void MakeSuvCar()
        {
            this._builder.SetName("Type of suv car");
            this._builder.SetBody();
            this._builder.SetEngine();
        }

        public void MakeSportCar()
        {
            this._builder.SetName("Type of sport car");
            this._builder.SetBody();
            this._builder.SetEngine();
        }
    }
}