using WebApplication4.Enums;

namespace WebApplication4.Models;

public class UserTask
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public DateTime DueTo { get; set; }
    public string Assignee { get; set; }
    public string Category { get; set; }

    public TASK_STATUS Status { get; set; } = TASK_STATUS.PENDING;
    public TASK_PRIORITY Priority { get; set; } = TASK_PRIORITY.LOW;
}


