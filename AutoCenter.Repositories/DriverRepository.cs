using AutoCenter.Models;
using AutoCenter.Repositories.Contexts;
using AutoCenter.Repositories.Interfaces;

namespace AutoCenter.Repositories;

internal class DriverRepository : RepositoryBase<Driver>, IDriverRepository
{
    internal DriverRepository(AutoDbContext context) : base(context)
    {

    }
}