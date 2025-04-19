using Logonaut.Infra.Data.Abstractions;
using Logonaut.Infra.Data.Context;

namespace Logonaut.Infra.Data;

public class UnitOfWork(ApplicationDbContext context) : IUnitOfWork
{
    private readonly ApplicationDbContext _context = context;

    public Task<int> CommitAsync()
    {
        return _context.SaveChangesAsync();
    }
}