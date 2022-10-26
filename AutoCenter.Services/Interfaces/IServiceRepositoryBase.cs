namespace AutoCenter.Services.Interfaces;

public interface IServiceRepositoryBase<T> : IServiceBase<T> where T : class
{
    void Add(T entity);
    void Load();
    T GetById(object id);
    void Update(T entity);
    void Remove(T entity);
}