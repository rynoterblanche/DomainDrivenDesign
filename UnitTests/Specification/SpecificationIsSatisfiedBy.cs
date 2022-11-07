using UnitTests.Specification.Fixture.Entities;
using UnitTests.Specification.Fixture.Specs;

namespace UnitTests.Specification;

public class SpecificationIsSatisfiedBy
{
    private readonly NumberIsEvenSpecification _numberIsEvenSpec = new();
    private readonly NumberIsPositiveSpecification _numberIsPositiveSpec = new();

    [Fact]
    public void ReturnsTrue_GivenEntityPassesSingleSpec()
    {
        var result = _numberIsEvenSpec.IsSatisfiedBy(new Number(4));

        Assert.True(result);
    }

    [Fact]
    public void ReturnsFalse_GivenEntityFailsSingleSpec()
    {
        var result = _numberIsEvenSpec.IsSatisfiedBy(new Number(3));

        Assert.False(result);
    }

    [Fact]
    public void ReturnsTrue_GivenEntityPassesCombinedAndSpec()
    {
        var isEvenAndPositive = _numberIsEvenSpec.And(_numberIsPositiveSpec);

        var result = isEvenAndPositive.IsSatisfiedBy(new Number(4));

        Assert.True(result);
    }

    [Fact]
    public void ReturnsFalse_GivenEntityFailsCombinedAndSpec()
    {
        var isEvenAndPositive = _numberIsEvenSpec.And(_numberIsPositiveSpec);

        var result = isEvenAndPositive.IsSatisfiedBy(new Number(-4));

        Assert.False(result);
    }

    [Fact]
    public void ReturnsTrue_GivenEntityPassesCombinedOrSpec()
    {
        var isEvenOrPositive = _numberIsEvenSpec.Or(_numberIsPositiveSpec);

        var result = isEvenOrPositive.IsSatisfiedBy(new Number(3));

        Assert.True(result);
    }

    [Fact]
    public void ReturnsFalse_GivenEntityFailsCombinedOrSpec()
    {
        var isEvenOrPositive = _numberIsEvenSpec.Or(_numberIsPositiveSpec);

        var result = isEvenOrPositive.IsSatisfiedBy(new Number(-3));

        Assert.False(result);
    }

    [Fact]
    public void ReturnsTrue_GivenEntityPassesNotSpec()
    {
        var notEven = _numberIsEvenSpec.Not();

        var result = notEven.IsSatisfiedBy(new Number(7));

        Assert.True(result);
    }

}