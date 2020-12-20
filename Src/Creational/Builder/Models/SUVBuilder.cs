namespace Builder.Models
{
    public class SUVBuilder : ICarBuilder
    {
        private Car _Car = new Car();

        public SUVBuilder()
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
            this._Car.SetBody(BodyType.SUV);
        }

        public void SetEngine()
        {
            this._Car.SetEngine(EngineType.Diesal);
        }

        public Car GetCar()
        {
            Car result = this._Car;

            this.Reset();

            return result;
        }
    }
}