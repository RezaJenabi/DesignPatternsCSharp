namespace Specification.Specifications
{
    public abstract class CompositeSpecification<T> : ISpecification<T>
    {
        public abstract bool IsSatisfiedBy(T candidate);
        public ISpecification<T> And(ISpecification<T> other) => new AndSpecification<T>(this, other);

    }
}