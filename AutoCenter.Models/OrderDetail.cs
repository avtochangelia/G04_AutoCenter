namespace AutoCenter.Models;

public class OrderDetail
{
    public int OrderID { get; set; }
    public Order? Order { get; set; }

    public int CarID { get; set; }
    public Car? Car { get; set; }

    public double Price { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public int DriverID { get; set; }
    public Driver? Driver { get; set; }
}