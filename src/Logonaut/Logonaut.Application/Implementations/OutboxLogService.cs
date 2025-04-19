using Logonaut.Application.Abstractions;
using Logonaut.Domain.Abstractions;
using Logonaut.Domain.Entities;

namespace Logonaut.Application.Implementations;

public class OutboxLogService(IOutboxLogRepository outboxLogRepository) : IOutboxLogService
{
    private readonly IOutboxLogRepository _outboxLogRepository = outboxLogRepository;

    public Task<List<OutboxLog>> GetOutboxLogsAsync()
        => _outboxLogRepository.GetOutboxLogsAsync();

    public void InsertAsync(OutboxLog outboxLog)
    {
        _outboxLogRepository.InsertAsync(outboxLog);
    }
}