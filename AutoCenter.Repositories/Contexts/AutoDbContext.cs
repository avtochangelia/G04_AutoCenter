using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using AutoCenter.Models;

namespace AutoCenter.Repositories.Contexts;

public class AutoDbContext : DbContext
{
    private readonly string _connectionString;

    public AutoDbContext(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("Default");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(_connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Employee
        modelBuilder.Entity<Employee>(e =>
        {
            e.Property(x => x.ID).HasColumnOrder(1);
            e.Property(x => x.EmployeeType).HasColumnOrder(2);
            e.Property(x => x.FirstName).HasMaxLength(20).IsRequired();
            e.Property(x => x.LastName).HasMaxLength(30).IsRequired();
            e.Property(x => x.Adress).HasMaxLength(100).IsRequired();
            e.Property(x => x.Phone).HasMaxLength(15).IsRequired();

            e.HasDiscriminator<string>("EmployeeType")
             .HasValue<Administrator>("Administrator")
             .HasValue<Driver>("Driver")
             .HasValue<Technician>("Technician");
        });

        //Administrator
        modelBuilder.Entity<Administrator>(a =>
        {
            a.Property(x => x.Position).HasMaxLength(25);
            a.Property(x => x.Education).HasMaxLength(25);
        });

        //Driver
        modelBuilder.Entity<Driver>(d =>
        {
            d.Property(x => x.DriverLicense).HasMaxLength(50);
            d.Property(x => x.LicenseCategory).HasMaxLength(25);
        });

        //Technician
        modelBuilder.Entity<Technician>(t =>
        {
            t.Property(x => x.Qualification).HasMaxLength(25);
            t.Property(x => x.Experience).HasMaxLength(25);
        });

        //Car
        modelBuilder.Entity<Car>(c =>
        {
            c.Property(x => x.Brand).HasMaxLength(25).IsRequired();
            c.Property(x => x.Model).HasMaxLength(25).IsRequired();
            c.Property(x => x.Color).HasMaxLength(25).IsRequired();
            c.Property(x => x.RegistrationNumber).HasMaxLength(25).IsRequired();
            c.Property(x => x.RecentPrice).HasColumnType("Money").IsRequired();

            c.HasOne(x => x.CarCategory)
             .WithMany(x => x.Cars)
             .HasForeignKey(x => x.CarCategoryID);
        });

        //CarCategory
        modelBuilder.Entity<CarCategory>(cc =>
        {
            cc.Property(x => x.Name).HasMaxLength(20).IsRequired();

            cc.HasOne(cc => cc.Technican)
              .WithOne(t => t.CarClass)
              .HasForeignKey<CarCategory>(cc => cc.TechnicianID);
        });

        //Customer
        modelBuilder.Entity<Customer>(c =>
        {
            c.Property(x => x.FullName).HasMaxLength(100).IsRequired();
            c.Property(x => x.Adress).HasMaxLength(100).IsRequired();
            c.Property(x => x.Phone).HasMaxLength(15).IsRequired();
        });

        //Order
        modelBuilder.Entity<Order>(o =>
        {
            o.Property(x => x.OrderDate).IsRequired();

            o.HasOne(x => x.Customer)
             .WithMany(x => x.Orders)
             .HasForeignKey(x => x.CustomerID);

            o.HasOne(x => x.Administrator)
             .WithMany(x => x.Orders)
             .HasForeignKey(x => x.AdministratorID);
        });

        //OrderDetail
        modelBuilder.Entity<OrderDetail>(od =>
        {
            od.Property(x => x.Price).HasColumnType("Money").IsRequired();
            od.Property(x => x.StartDate).IsRequired();
            od.Property(x => x.EndDate).IsRequired();

            od.HasKey(x => new { x.OrderID, x.CarID });

            od.HasOne(x => x.Order)
              .WithMany(x => x.OrderDetails)
              .HasForeignKey(x => x.OrderID)
              .OnDelete(DeleteBehavior.Restrict);

            od.HasOne(y => y.Car)
              .WithMany(y => y.OrderDetails)
              .HasForeignKey(y => y.CarID)
              .OnDelete(DeleteBehavior.Restrict);

            od.HasOne(x => x.Driver)
             .WithMany(x => x.OrderDetails)
             .HasForeignKey(x => x.DriverID);
        });
    }

    public DbSet<Employee>? Employees { get; set; }
    public DbSet<Car>? Cars { get; set; }
    public DbSet<CarCategory>? CarCategories { get; set; }
    public DbSet<Customer>? Customers { get; set; }
    public DbSet<Order>? Orders { get; set; }
    public DbSet<OrderDetail>? OrderDetails { get; set; }
}