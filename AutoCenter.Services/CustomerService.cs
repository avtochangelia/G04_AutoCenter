using AutoCenter.Models;
using AutoCenter.Repositories.Interfaces;
using AutoCenter.Services.Interfaces;

namespace AutoCenter.Services;

public class CustomerService : ServiceRepositoryBase<Customer>, ICustomerService
{
	public CustomerService(ICustomerRepository repository) : base(repository)
	{

	}
}