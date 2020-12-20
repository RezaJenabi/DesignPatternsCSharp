namespace Adapter.Models
{
    public class RailAdapter : IRailAdapter
    {
        private readonly Car _car;

        public RailAdapter(Car car)
        {
            this._car = car;
        }

        public string Move() 
        {
            return $"'{this._car.Move()}' to rail";
        }
    }
}