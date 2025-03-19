using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Services.Interfaces;
using WebApplication4.Models;
using WebApplication4.Enums;
using WebApplication4.Request;
using WebApplication4.Data;
namespace WebApplication4.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    private readonly ITaskService _taskService;

    public TaskController(ITaskService taskService)
    {
        _taskService = taskService;
    }

    [HttpPost("add-task")]
    public UserTask AddTask(AddTask task)
    {
        return _taskService.AddUserTask(task);
    }

    [HttpGet("get-all-tasks")]
    public List<UserTask> GetAllTasks()
    {
        return _taskService.GetAllTasks();
    }

    [HttpGet("get-all-tasks-completed")]
    public List<UserTask> GetCompletedTasks()
    {
        return _taskService.GetAllCompletedTasks();
    }

    [HttpPut("complete-task")]
    public UserTask CompleteTask(int id)
    {
        return _taskService.CompleteTask(id);
    }



}
