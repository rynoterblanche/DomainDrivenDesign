using UnitTests.ValueObject.Fixture;

namespace UnitTests.ValueObject;

public class ValueObjectEquals
{
    [Theory]
    [MemberData(nameof(TestDataGenerator.GetMatchingFullNames), MemberType = typeof(TestDataGenerator))]
    public void ReturnsTrueForMatchingValueObjects(FullName left, FullName right)
    {
        Assert.True(left.Equals(right));
        Assert.True(left == right);
    }

    [Theory]
    [MemberData(nameof(TestDataGenerator.GetNonMatchingFullNames), MemberType = typeof(TestDataGenerator))]
    public void ReturnsFalseForNonMatchingValueObjects(FullName left, FullName right)
    {
        Assert.False(left.Equals(right));
        Assert.True(left != right);
    }
}

public class TestDataGenerator
{
    public static IEnumerable<object[]> GetMatchingFullNames()
    {
        yield return new object[]
        {
            new FullName("name"),
            new FullName("name")
        };

        yield return new object[]
        {
            new FullName("fName", "lastName"),
            new FullName("fName", "lastName")
        };

        yield return new object[]
        {
            new FullName("title", "fName", "lastName"),
            new FullName("title", "fName", "lastName")
        };

        yield return new object[]
        {
            new FullName("title", "fName", "mName","lastName"),
            new FullName("title", "fName", "mName","lastName")
        };
    }

    public static IEnumerable<object[]> GetNonMatchingFullNames()
    {
        yield return new object[]
        {
            new FullName("name1"),
            new FullName("name2")
        };

        yield return new object[]
        {
            new FullName("fName1", "lastName"),
            new FullName("fName2", "lastName")
        };

        yield return new object[]
        {
            new FullName("title1", "fName", "lastName"),
            new FullName("fName", "lastName")
        };

        yield return new object[]
        {
            new FullName( "fName","lastName"),
            new FullName("title", "fName", "mName2","lastName")
        };
    }
}