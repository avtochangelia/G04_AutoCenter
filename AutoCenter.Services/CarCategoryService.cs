using AutoCenter.Models;
using AutoCenter.Repositories.Interfaces;
using AutoCenter.Services.Interfaces;

namespace AutoCenter.Services;

public class CarCategoryService : ServiceRepositoryBase<CarCategory>, ICarCategoryService
{
	public CarCategoryService(ICarCategoryRepository repository) : base(repository)
	{

	}
}