using System;
using System.Linq.Expressions;
using Specification.Mobiles;
using Specification.Specifications;
using Type = Specification.Mobiles.Type;

namespace Specification.MobilesSpecification
{
    public class TypeSmartSpecification : LinqSpecification<Mobile>
    {
        public override Expression<Func<Mobile, bool>> AsExpression()
        {
            return (customer) => (customer.Type == Type.Smart);
        }
    }
}