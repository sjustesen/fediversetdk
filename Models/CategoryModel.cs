using System.ComponentModel.DataAnnotations;

namespace Fediverset.Models;

public class Category
{
    [Key]
    public int CategoryId { get; set; }
    public Guid UUID { get; set; }
    public bool Active { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public virtual ICollection<Link>? Links { get; set; }
}
