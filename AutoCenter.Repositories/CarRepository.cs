using AutoCenter.Models;
using AutoCenter.Repositories.Contexts;
using AutoCenter.Repositories.Interfaces;

namespace AutoCenter.Repositories;

internal class CarRepository : RepositoryBase<Car>, ICarRepository
{
    internal CarRepository(AutoDbContext context) : base(context)
    {

	}
}