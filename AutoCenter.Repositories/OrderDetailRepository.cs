using AutoCenter.Models;
using AutoCenter.Repositories.Contexts;
using AutoCenter.Repositories.Interfaces;

namespace AutoCenter.Repositories;

internal class OrderDetailRepository : RepositoryBase<OrderDetail>, IOrderDetailRepository
{
    internal OrderDetailRepository(AutoDbContext context) : base(context)
    {

	}
}