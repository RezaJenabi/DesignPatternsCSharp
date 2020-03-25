namespace Composite
{
    public class Products : Component
    {
        private string _name;
        public Products(string name)
        {
            Name = name;
        }

        public string Name { get => _name; set => _name = value; }


        public override string Operation()
        {
            return $"Leaf is {Name}";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}