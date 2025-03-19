using WebApplication4.Models;
using WebApplication4.Enums;
using WebApplication4.Request;
using WebApplication4.Services.Interfaces;
using WebApplication4.Data;

namespace WebApplication4.Services.Implementation;

public class TaskService : ITaskService
{
    private readonly DataContext _context;

    public TaskService(DataContext context)
    {
        _context = context;
    }

    public UserTask AddUserTask(AddTask task)
    {
        UserTask taskToAdd = new UserTask
        {
            Name = task.Name,
            Description = task.Description,
            DueTo = task.DueTo,
            Assignee = task.Assignee,
            Category = task.Category,
        };

        _context.Tasks.Add(taskToAdd);
        _context.SaveChanges();

        return taskToAdd;
    }

    public UserTask CompleteTask(int id)
    {
        var taskToComplete = _context.Tasks.FirstOrDefault(x => x.Id == id);


        taskToComplete.Status = TASK_STATUS.COMPLETED;

        _context.Tasks.Update(taskToComplete);
        _context.SaveChanges();

        return taskToComplete;
    }

    public UserTask DeleteTask(int id)
    {
        var taskToDelete = _context.Tasks.FirstOrDefault(x => x.Id == id);

        _context.Tasks.Remove(taskToDelete);
        _context.SaveChanges();

        return taskToDelete;
    }

    public List<UserTask> GetAllCompletedTasks()
    {
        return _context.Tasks.Where(t => t.Status == TASK_STATUS.COMPLETED).ToList();
    }

    public List<UserTask> GetAllTasks()
    {
        return _context.Tasks.ToList();
    }

    public UserTask InProgressTask(int id)
    {
        var taskToInprogress = _context.Tasks.FirstOrDefault(x => x.Id == id);


        taskToInprogress.Status = TASK_STATUS.INPROGRESS;

        _context.Tasks.Update(taskToInprogress);
        _context.SaveChanges();

        return taskToInprogress;
    }
}
