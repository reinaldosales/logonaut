using Logonaut.Domain.Models.OutboxLog;

namespace Logonaut.Domain.Entities;

public class OutboxLog : Entity<Guid>
{
    // EF core
    protected OutboxLog() { }

    public OutboxLog(
        string sourceApp,
        string payload,
        bool processed,
        DateTime? processedAt,
        DateTime createdAt,
        DateTime updatedAt,
        DateTime? deletedAt) : base(createdAt, updatedAt, deletedAt)
    {
        SourceApp = sourceApp;
        Payload = payload;
        Processed = processed;
        ProcessedAt = processedAt;
    }
    
    public string SourceApp { get; private set; }
    public string Payload { get; private set; }
    public bool Processed { get; private set; }
    public DateTime? ProcessedAt { get; private set; }

    public static OutboxLog CreateOutboxLogModelToEntity(CreateOutboxLogModel createOutboxLogModel)
        => new OutboxLog(
            createOutboxLogModel.SourceApp,
            createOutboxLogModel.Payload,
            createOutboxLogModel.Processed,
            createOutboxLogModel.ProcessedAt,
            createdAt: DateTime.Now,
            updatedAt: DateTime.Now,
            deletedAt: null);
}