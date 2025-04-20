using Logonaut.Application.Abstractions;
using Logonaut.Domain.Abstractions;
using Logonaut.Domain.Entities;
using Logonaut.Domain.Models.OutboxLog;

namespace Logonaut.Application.Implementations;

public class OutboxLogService(IOutboxLogRepository outboxLogRepository) : IOutboxLogService
{
    private readonly IOutboxLogRepository _outboxLogRepository = outboxLogRepository;

    public Task<List<OutboxLog>> GetOutboxLogsAsync()
        => _outboxLogRepository.GetOutboxLogsAsync();

    public async Task InsertAsync(CreateOutboxLogModel model)
    {
        OutboxLog outboxLog = OutboxLog.CreateOutboxLogModelToEntity(model);
        
        await _outboxLogRepository.InsertAsync(outboxLog);
    }
}