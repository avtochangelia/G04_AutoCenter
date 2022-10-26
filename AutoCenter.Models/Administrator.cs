namespace AutoCenter.Models;

public class Administrator : Employee
{
    public string? Position { get; set; }
    public string? Education { get; set; }

    public ICollection<Order>? Orders { get; set; }
}