using AutoCenter.Models;
using AutoCenter.Repositories.Contexts;
using AutoCenter.Repositories.Interfaces;

namespace AutoCenter.Repositories;

internal class TechnicianRepository : RepositoryBase<Technician>, ITechnicianRepository
{
    internal TechnicianRepository(AutoDbContext context) : base(context)
    {

	}
}