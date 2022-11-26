namespace Fediverset.Models;

public class LinkModel
{
    public int LinkId { get; set; }
    public Guid Parent { get; set; }
    public bool Active { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
}
