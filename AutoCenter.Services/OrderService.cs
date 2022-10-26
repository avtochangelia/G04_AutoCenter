using AutoCenter.Models;
using AutoCenter.Repositories.Interfaces;
using AutoCenter.Services.Interfaces;

namespace AutoCenter.Services;

public class OrderService : ServiceRepositoryBase<Order>, IOrderService
{
	public OrderService(IOrderRepository repository) : base(repository)
	{

	}
}