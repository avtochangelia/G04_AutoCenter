namespace AutoCenter.Models;

public class Driver : Employee
{
    public string? DriverLicense { get; set; }
    public string? LicenseCategory { get; set; }

    public ICollection<OrderDetail>? OrderDetails { get; set; }
}