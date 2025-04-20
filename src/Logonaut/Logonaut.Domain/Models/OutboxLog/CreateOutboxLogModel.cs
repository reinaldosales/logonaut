using Logonaut.Domain.Entities;

namespace Logonaut.Domain.Models.OutboxLog;

public record CreateOutboxLogModel(
    string SourceApp,
    string Payload,
    bool Processed,
    DateTime? ProcessedAt);