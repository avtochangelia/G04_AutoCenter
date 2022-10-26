namespace AutoCenter.Models;

public class Customer
{
    public int ID { get; set; }
    public string? FullName { get; set; }
    public string? Adress { get; set; }
    public string? Phone { get; set; }

    public ICollection<Order>? Orders { get; set; }
}