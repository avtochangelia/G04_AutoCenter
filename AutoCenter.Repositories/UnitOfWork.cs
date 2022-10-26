using AutoCenter.Repositories;
using AutoCenter.Repositories.Contexts;
using AutoCenter.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;

namespace AutoCenter.Repository;

public class UnitOfWork : IDisposable
{
    private readonly AutoDbContext _context;
    private readonly IDbContextTransaction _transaction;
    private readonly Lazy<IAdministratorRepository>? _administratorRepository;
    private readonly Lazy<ICarCategoryRepository>? _carCategoryRepository;
    private readonly Lazy<ICarRepository>? _carRepository;
    private readonly Lazy<ICustomerRepository>? _customerRepository;
    private readonly Lazy<IDriverRepository>? _driverRepository;
    private readonly Lazy<IOrderDetailRepository>? _orderDetailRepository;
    private readonly Lazy<IOrderRepository>? _orderRepository;
    private readonly Lazy<ITechnicianRepository>? _technicianRepository;

    public UnitOfWork(IConfiguration configuration)
    {
        _context = new(configuration);
        _transaction = _context.Database.BeginTransaction();

        _administratorRepository = new Lazy<IAdministratorRepository>(() => new AdministratorRepository(_context));
        _carCategoryRepository = new Lazy<ICarCategoryRepository>(() => new CarCategoryRepository(_context));
        _carRepository = new Lazy<ICarRepository>(() => new CarRepository(_context));
        _customerRepository = new Lazy<ICustomerRepository>(() => new CustomerRepository(_context));
        _driverRepository = new Lazy<IDriverRepository>(() => new DriverRepository(_context));
        _orderDetailRepository = new Lazy<IOrderDetailRepository>(() => new OrderDetailRepository(_context));
        _orderRepository = new Lazy<IOrderRepository>(() => new OrderRepository(_context));
        _technicianRepository = new Lazy<ITechnicianRepository>(() => new TechnicianRepository(_context));
    }

    public IAdministratorRepository administratorRepository => _administratorRepository!.Value;
    public ICarCategoryRepository CarCategoryRepository => _carCategoryRepository!.Value;
    public ICarRepository CarRepository => _carRepository!.Value;
    public ICustomerRepository CustomerRepository => _customerRepository!.Value;
    public IDriverRepository DriverRepository => _driverRepository!.Value;
    public IOrderDetailRepository OrderDetailRepository => _orderDetailRepository!.Value;
    public IOrderRepository OrderRepository => _orderRepository!.Value;
    public ITechnicianRepository TechnicianRepository => _technicianRepository!.Value;

    public IDbContextTransaction BeginTransaction() => _transaction;

    public int SaveChanges => _context.SaveChanges();

    public void Dispose()
    {
        _context.Dispose();
        _transaction.Dispose();
    }
}