namespace Fediverset.Models;

public class CategoryModel
{
    public int CategoryId { get; set; }
    public Guid UUID { get; set; }
    public bool Active { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
}
