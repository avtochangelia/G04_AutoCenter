namespace AutoCenter.Models;

public class Technician : Employee
{
    public string? Qualification { get; set; }
    public string? Experience { get; set; }

    public CarCategory? CarClass { get; set; }
}