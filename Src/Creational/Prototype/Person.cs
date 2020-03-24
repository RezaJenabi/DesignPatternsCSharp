namespace Prototype
{
    public class Person
    {
        private string _name;

        public Address Address { get; set; }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clone = (Person)this.MemberwiseClone();

            Address address = new Address(Address.GetStreet());

            clone.Address = address;
            return clone;
        }

        public override string ToString()
        {
            return $"my name {_name} live in {Address?.GetStreet()}";
        }
    }
}
