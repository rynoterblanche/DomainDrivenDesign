using System.Linq.Expressions;

namespace Specification;

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