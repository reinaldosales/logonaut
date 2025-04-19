using Logonaut.Domain.Abstractions;
using Logonaut.Domain.Entities;
using Logonaut.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Logonaut.Infra.Data.Implementations;

public class OutboxLogRepository(ApplicationDbContext context) : IOutboxLogRepository
{
    private readonly ApplicationDbContext _context = context;

    public Task<List<OutboxLog>> GetOutboxLogsAsync()
        => _context.OutboxLogs.ToListAsync();

    public void InsertAsync(OutboxLog outboxLog)
    {
        _context.OutboxLogs.AddAsync(outboxLog);
    }
}