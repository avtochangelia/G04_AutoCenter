namespace AutoCenter.Models;

public class Car
{
    public int ID { get; set; }
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public string? Color { get; set; }
    public int RegistrationNumber { get; set; }
    public double RecentPrice { get; set; }

    public int CarCategoryID { get; set; }
    public CarCategory? CarCategory { get; set; }

    public ICollection<OrderDetail>? OrderDetails { get; set; }
}