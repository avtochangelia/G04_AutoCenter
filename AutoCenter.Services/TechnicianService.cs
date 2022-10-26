using AutoCenter.Models;
using AutoCenter.Repositories.Interfaces;
using AutoCenter.Services.Interfaces;

namespace AutoCenter.Services;

public class TechnicianService : ServiceRepositoryBase<Technician>, ITechnicianService
{
	public TechnicianService(ITechnicianRepository repository) : base(repository)
	{

	}
}