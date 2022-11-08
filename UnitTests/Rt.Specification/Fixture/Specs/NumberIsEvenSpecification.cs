using System.Linq.Expressions;
using Specification.Rt.Specification;
using UnitTests.Rt.Specification.Fixture.Entities;

namespace UnitTests.Rt.Specification.Fixture.Specs;

public class NumberIsEvenSpecification : Specification<Number>
{
    public override Expression<Func<Number, bool>> ToExpression()
    {
        return number => number.Value % 2 == 0;
    }
}