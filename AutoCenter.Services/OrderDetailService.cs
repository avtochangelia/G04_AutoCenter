using AutoCenter.Models;
using AutoCenter.Repositories.Interfaces;
using AutoCenter.Services.Interfaces;

namespace AutoCenter.Services;

public class OrderDetailService : ServiceRepositoryBase<OrderDetail>, IOrderDetailService
{
	public OrderDetailService(IOrderDetailRepository repository) : base(repository)
	{

	}
}