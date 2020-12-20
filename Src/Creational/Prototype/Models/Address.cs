namespace Prototype.Models
{
    public class Address
    {
        private string _city;

        public Address(string city)
        {
            SetStreet(city);
        }

        public void SetStreet(string city)
        {
            _city = city;
        }
        public string GetStreet()
        {
            return _city;
        }

        public override string ToString()
        {
            return $"live  in {_city}";
        }
    }
}
