using AutoCenter.Models;
using AutoCenter.Repositories.Contexts;
using AutoCenter.Repositories.Interfaces;

namespace AutoCenter.Repositories;

internal class AdministratorRepository : 
	RepositoryBase<Administrator>, IAdministratorRepository
{
    internal AdministratorRepository(AutoDbContext context) : base(context)
	{

	}
}