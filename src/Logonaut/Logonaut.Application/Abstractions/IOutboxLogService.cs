using Logonaut.Domain.Entities;
using Logonaut.Domain.Models.OutboxLog;

namespace Logonaut.Application.Abstractions;

public interface IOutboxLogService
{
    Task<List<OutboxLog>> GetOutboxLogsAsync();
    Task InsertAsync(CreateOutboxLogModel model);
}