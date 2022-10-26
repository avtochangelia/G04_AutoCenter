using AutoCenter.Models;
using AutoCenter.Repositories.Contexts;
using AutoCenter.Repositories.Interfaces;

namespace AutoCenter.Repositories;

internal class CarCategoryRepository : RepositoryBase<CarCategory>, ICarCategoryRepository
{
    internal CarCategoryRepository(AutoDbContext context) : base(context)
    {

	}
}