using Logonaut.Domain.Entities;

namespace Logonaut.Application.Abstractions;

public interface IOutboxLogService
{
    Task<List<OutboxLog>> GetOutboxLogsAsync();
    void InsertAsync(OutboxLog outboxLog);
}