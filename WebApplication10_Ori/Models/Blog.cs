namespace WebApplication10a.Models;

public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }
    
    public DateTime LoadedFromDatabase { get; set; }
    
}