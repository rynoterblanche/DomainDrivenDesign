using Specification.Demo.Core.Interfaces;

namespace Specification.Demo.Core.Entities.WorkflowAggregate;

public class Workflow : Entity<Guid>, IAggregateRoot
{
    private readonly List<WfTask> _tasks = new();

    public string Name { get; }

    public IEnumerable<WfTask> Tasks => _tasks.AsReadOnly();

    public WorkflowStatus Status => _tasks.All(t => t.IsDone) ? WorkflowStatus.Complete : WorkflowStatus.InProgress;
    public DateTime RunDate { get; }

    public Workflow(string name, DateTime runDate)
    {
        Name = name;
        RunDate = runDate;
    }

    public void AddTask(WfTask newTask)
    {
        _tasks.Add(newTask);
    }
}