namespace Decorator.Models
{
    public class ConcreteLowercaseDecorator : Decorator
    {
        public ConcreteLowercaseDecorator(IComponent comp) : base(comp)
        {
        }

        public override string GetInfo()
        {
            return base.GetInfo().ToLower();
        }
    }
}
