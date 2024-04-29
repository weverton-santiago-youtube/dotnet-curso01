using System.Security.Claims;
using dataContext;
using interfaces;

namespace repositories;

public interface IEntityId
{
    int entityId { get; set; }
}

public class GlobalRepository<T> : IGlobalRepository<T> where T : class
{
    protected readonly DataContext _context;

    public GlobalRepository(DataContext context)
    {
        _context = context;
    }

    public string GetUserId(ClaimsPrincipal userIdClaims)
    {
        var userId = userIdClaims.FindFirstValue(ClaimTypes.NameIdentifier);

        if (string.IsNullOrEmpty(userId))
        {
            throw new Exception("Acesso negado!");
        }

        return userId;
    }

    public async Task<T> AddAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        return entity;
    }
}