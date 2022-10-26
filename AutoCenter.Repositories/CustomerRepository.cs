using AutoCenter.Models;
using AutoCenter.Repositories.Contexts;
using AutoCenter.Repositories.Interfaces;

namespace AutoCenter.Repositories;

internal class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
{
    internal CustomerRepository(AutoDbContext context) : base(context)
    {

	}
}