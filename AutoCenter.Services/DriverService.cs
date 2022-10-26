using AutoCenter.Models;
using AutoCenter.Repositories.Interfaces;
using AutoCenter.Services.Interfaces;

namespace AutoCenter.Services;

public class DriverService : ServiceRepositoryBase<Driver>, IDriverService
{
	public DriverService(IDriverRepository repository) : base(repository)
	{

	}
}