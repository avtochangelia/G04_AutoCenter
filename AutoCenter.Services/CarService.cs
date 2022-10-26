using AutoCenter.Models;
using AutoCenter.Repositories.Interfaces;
using AutoCenter.Services.Interfaces;

namespace AutoCenter.Services;

public class CarService : ServiceRepositoryBase<Car>, ICarService
{
	public CarService(ICarRepository repository) : base(repository)
	{

	}
}