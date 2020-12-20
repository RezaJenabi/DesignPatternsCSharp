namespace Decorator.Models
{
    public class ConcreteUppercaseDecorator : Decorator
    {
        public ConcreteUppercaseDecorator(IComponent comp) : base(comp)
        {
        }

        public override string GetInfo()
        {
            return base.GetInfo().ToUpper();
        }
    }
}
