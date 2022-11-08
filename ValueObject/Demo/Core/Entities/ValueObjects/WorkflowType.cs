namespace ValueObject.Demo.Core.Entities.ValueObjects;

public class WorkflowType: Rt.ValueObject.ValueObject
{
    public string Category { get; }
    public string Organization { get; }

    public WorkflowType(string category, string organization)
    {
        Category = category;
        Organization = organization;
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Category;
        yield return Organization;
    }
}