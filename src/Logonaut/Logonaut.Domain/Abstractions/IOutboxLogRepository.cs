using Logonaut.Domain.Entities;

namespace Logonaut.Domain.Abstractions;

public interface IOutboxLogRepository
{
    Task<List<OutboxLog>> GetOutboxLogsAsync();
    void InsertAsync(OutboxLog outboxLog);
}