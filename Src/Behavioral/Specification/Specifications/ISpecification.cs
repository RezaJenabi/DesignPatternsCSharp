namespace Specification.Specifications
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T candidate);
        ISpecification<T> And(ISpecification<T> other);
    }
}