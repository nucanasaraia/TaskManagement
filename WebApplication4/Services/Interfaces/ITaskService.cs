using WebApplication4.Models;
using WebApplication4.Enums;
using WebApplication4.Request;

namespace WebApplication4.Services.Interfaces;

public interface ITaskService
{
    UserTask AddUserTask(AddTask request);

    List<UserTask> GetAllTasks();

    UserTask InProgressTask(int id);

    UserTask CompleteTask(int id);

    List<UserTask> GetAllCompletedTasks();

    UserTask DeleteTask(int id);
}
