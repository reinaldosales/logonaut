using System.Text.Json;
using Logonaut.Application.Abstractions;
using Logonaut.Client.Abstractions;
using Logonaut.Domain.Entities;
using Logonaut.Domain.Models.OutboxLog;

namespace Logonaut.Client.Implementations;

public class LogonautLogger(
    IOutboxLogService outboxLogService,
    LogonautOpptions options) : ILogonautLogger
{
    private readonly IOutboxLogService _outboxLogService = outboxLogService;
    private readonly LogonautOpptions _options = options;
    
    public async Task LogAsync(string payload)
    {
        CreateOutboxLogModel model = new(
            _options.SourceApp,
            payload,
            Processed: false,
            ProcessedAt: null);
        
        await _outboxLogService.InsertAsync(model);
    }
}