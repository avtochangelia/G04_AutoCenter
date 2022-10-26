namespace AutoCenter.Models;

public class CarCategory
{
    public int ID { get; set; }
    public string? Name { get; set; }

    public int TechnicianID { get; set; }
    public Technician? Technican { get; set; }

    public ICollection<Car>? Cars { get; set; }
}