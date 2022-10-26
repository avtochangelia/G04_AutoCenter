using AutoCenter.Models;
using AutoCenter.Repositories.Interfaces;
using AutoCenter.Services.Interfaces;

namespace AutoCenter.Services;

public class AdministratorService : ServiceRepositoryBase<Administrator>, IAdministratorService
{
	public AdministratorService(IAdministratorRepository repository) : base(repository)
	{

	}
}