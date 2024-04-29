namespace interfaces;
public interface IGlobalRepository<T>
{
    Task<T> AddAsync(T entity);
}