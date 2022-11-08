using Repository.Demo.Core.Interfaces;

namespace Repository.Demo.Core.Entities.WorkflowAggregate;

public class Workflow : IAggregateRoot<Guid>
{
    private readonly List<WfTask> _tasks = new();

    public Guid Id { get; }

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