using Microsoft.EntityFrameworkCore;
using AutoCenter.Repositories.Contexts;
using AutoCenter.Repositories.Interfaces;

namespace AutoCenter.Repositories;

internal class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    protected readonly AutoDbContext _context;
    protected readonly DbSet<T> _table;

    internal RepositoryBase(AutoDbContext context)
    {
        _context = context;
        _table = _context.Set<T>();
    }

    public virtual void Add(T entity)
    {
        _table.Add(entity);
        _context.SaveChanges();
    }

    public virtual IEnumerable<T> Load()
        => _table;

    public virtual T GetById(object id)
        => _table.Find(id)!;

    public virtual void Update(T entity)
    {
        _table.Update(entity);
        _context.SaveChanges();
    }

    public virtual void Remove(T entity)
    {
        _table.Remove(entity);
        _context.SaveChanges();
    }
}