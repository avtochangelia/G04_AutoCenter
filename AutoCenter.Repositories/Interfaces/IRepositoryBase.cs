namespace AutoCenter.Repositories.Interfaces;

public interface IRepositoryBase<T> where T : class
{
    void Add(T entity);
    IEnumerable<T> Load();
    T GetById(object id);
    void Update(T entity);
    void Remove(T entity);
}