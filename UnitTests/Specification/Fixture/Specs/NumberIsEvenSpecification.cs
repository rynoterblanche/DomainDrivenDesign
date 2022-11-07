using System.Linq.Expressions;
using Specification;
using UnitTests.Specification.Fixture.Entities;

namespace UnitTests.Specification.Fixture.Specs;

public class NumberIsEvenSpecification : Specification<Number>
{
    public override Expression<Func<Number, bool>> ToExpression()
    {
        return number => number.Value % 2 == 0;
    }
}