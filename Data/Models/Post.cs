namespace _5_lesson.Models;

public class Post
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; }
    public string Body { get; set; }
    public int UserId { get; set; }             
}