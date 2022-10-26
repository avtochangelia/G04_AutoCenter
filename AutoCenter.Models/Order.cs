namespace AutoCenter.Models;

public class Order
{
    public int ID { get; set; }
    public DateTime OrderDate { get; set; }

    public int CustomerID { get; set; }
    public Customer? Customer { get; set; }

    public int AdministratorID { get; set; }
    public Administrator? Administrator { get; set; }

    public ICollection<OrderDetail>? OrderDetails { get; set; }
}