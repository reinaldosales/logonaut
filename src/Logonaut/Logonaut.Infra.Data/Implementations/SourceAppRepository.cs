using Logonaut.Domain.Abstractions;
using Logonaut.Domain.Entities;
using Logonaut.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Logonaut.Infra.Data.Implementations;

public class SourceAppRepository(ApplicationDbContext context) : ISourceAppRepository
{
    private readonly ApplicationDbContext _context = context;

    public Task<List<SourceApp>> GetOutboxLogsAsync()
        => _context.SourceApps.ToListAsync();

    public void InsertAsync(SourceApp sourceApp)
    {
        _context.SourceApps.AddAsync(sourceApp);
    }
}