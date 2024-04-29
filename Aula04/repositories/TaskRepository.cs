using dataContext;
using entities;
using interfaces;

namespace repositories;

public class TaskRepository : GlobalRepository<TaskEntity>, ITaskRepository
{
    public TaskRepository(DataContext context) : base(context)
    {
    }
    public TaskEntity GetCreateTaskEntityDTO(TaskEntity task, string userId)
    {
        TaskEntity taskEntity = new()
        {
            Id = Guid.NewGuid().ToString(),
            Title = task.Title,
            Description = task.Description,
            DateCreate = DateTime.Now,
            DateUpgrade = DateTime.Now,
            UserId = userId
        };
        return taskEntity;
    }
}