using AutoCenter.Models;
using AutoCenter.Repositories.Contexts;
using AutoCenter.Repositories.Interfaces;

namespace AutoCenter.Repositories;

internal class OrderRepository : RepositoryBase<Order>, IOrderRepository
{
    internal OrderRepository(AutoDbContext context) : base(context)
    {

	}
}