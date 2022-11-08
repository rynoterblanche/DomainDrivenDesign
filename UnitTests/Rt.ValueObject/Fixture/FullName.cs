namespace UnitTests.Rt.ValueObject.Fixture;

public class FullName: global::ValueObject.Rt.ValueObject.ValueObject
{
    public string Title { get; }
    public string FirstName { get; }
    public string MiddleName { get; }
    public string LastName { get; }

    public FullName(string name)
    {
        FirstName = name;
    }

    public FullName(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public FullName(string title, string firstName, string lastName)
    {
        Title = title;
        FirstName = firstName;
        LastName = lastName;
    }

    public FullName(string title, string firstName, string middleName, string lastName)
    {
        Title = title;
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Title;
        yield return FirstName;
        yield return MiddleName;
        yield return LastName;
    }
}