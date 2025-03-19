namespace WebApplication4.Request;

public class AddTask
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime DueTo { get; set; }
    public string Assignee { get; set; }
    public string Category { get; set; }
}
