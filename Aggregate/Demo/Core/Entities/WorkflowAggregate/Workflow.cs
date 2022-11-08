using Aggregate.Demo.Core.Interfaces;

namespace Aggregate.Demo.Core.Entities.WorkflowAggregate;

public class Workflow : Entity<Guid>, IAggregateRoot
{
    private readonly List<WfTask> _tasks = new();

    public string Name { get; }

    public IEnumerable<WfTask> Tasks => _tasks.AsReadOnly();

    public WorkflowStatus Status => _tasks.All(t => t.IsDone) ? WorkflowStatus.Complete : WorkflowStatus.InProgress;

    public Workflow(string name)
    {
        Name = name;
    }

    public void AddTask(WfTask newTask)
    {
        _tasks.Add(newTask);
    }
}