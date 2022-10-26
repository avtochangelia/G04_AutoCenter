using AutoCenter.Repositories.Interfaces;
using AutoCenter.Services.Interfaces;

namespace AutoCenter.Services;

public class ServiceRepositoryBase<T> : ServiceBase<T>, IServiceRepositoryBase<T> where T : class
{
    protected readonly IRepositoryBase<T> _repository;

    public ServiceRepositoryBase(IRepositoryBase<T> repository)
    {
        _repository = repository;
    }

    public void Add(T entity) => _repository.Add(entity);

    public void Load() => _repository.Load();

    public T GetById(object id) => _repository.GetById(id);

    public void Update(T entity) => _repository.Update(entity);

    public void Remove(T entity) => _repository.Remove(entity);
}