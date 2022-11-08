using System.Linq.Expressions;

namespace Specification.Rt.Specification;

/// <summary>
/// A starter implementation of a specification abstraction
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract class Specification<T>
{
    public bool IsSatisfiedBy(T entity)
    {
        var predicate = ToExpression().Compile();
        return predicate(entity);
    }

    public abstract Expression<Func<T, bool>> ToExpression();

    public Specification<T> And(Specification<T> spec)
    {
        return new AndSpecification<T>(this, spec);
    }

    public Specification<T> Or(Specification<T> spec)
    {
        return new OrSpecification<T>(this, spec);
    }

    public Specification<T> Not()
    {
        return new NotSpecification<T>(this);
    }
}