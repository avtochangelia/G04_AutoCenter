namespace AutoCenter.Models;

public abstract class Employee
{
    public int ID { get; set; }
    public string? EmployeeType { get; private set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Adress { get; set; }
    public string? Phone { get; set; }
}