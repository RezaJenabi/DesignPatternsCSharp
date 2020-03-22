using System;
using System.Linq.Expressions;
using Specification.Mobiles;
using Specification.Specifications;

namespace Specification.MobilesSpecification
{
    public class SamsungBrandNameSpecification : LinqSpecification<Mobile>
    {
        public override Expression<Func<Mobile, bool>> AsExpression()
        {
            return (customer) => (customer.BrandName == BrandName.Samsung);
        }

    }
}