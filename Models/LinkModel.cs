namespace Fediverset.Models;

public class Link
{
    public int LinkId { get; set; }
    public Guid Parent { get; set; }
    public bool Active { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public virtual Category? Category { get; set; }
}
