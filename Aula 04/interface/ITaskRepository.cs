using entities;

namespace interfaces;

public interface ITaskRepository : IGlobalRepository<TaskEntity>
{
    TaskEntity GetCreateTaskEntityDTO(TaskEntity task, string userId);

}