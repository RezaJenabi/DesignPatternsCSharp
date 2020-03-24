namespace Builder
{
    public class Car
    {
        private string _name;
        private BodyType _bodyType;
        private EngineType _engineType;

        public void SetName(string name)
        {
            _name= name;
        }

        public void SetEngine(EngineType engine)
        {
            _engineType = engine;
        }

        public void SetBody(BodyType body)
        {
            _bodyType = body;
        }

        public override string ToString()
        {
            return $"Name: {_name}, Engine: {_engineType}, Body: {_bodyType}";
        }
    }
}