namespace Builder
{
    public class SportBuilder : ICarBuilder
    {
        private Car _Car = new Car();

        public SportBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._Car = new Car();
        }

        public void SetName(string name)
        {
            this._Car.SetName(name);
        }

        public void SetBody()
        {
            this._Car.SetBody(BodyType.Sports);
        }

        public void SetEngine()
        {
            this._Car.SetEngine(EngineType.Sports);
        }

        public Car GetCar()
        {
            Car result = this._Car;

            this.Reset();

            return result;
        }
    }
}