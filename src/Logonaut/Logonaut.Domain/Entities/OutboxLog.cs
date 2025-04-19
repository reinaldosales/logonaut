namespace Logonaut.Domain.Entities;

public class OutboxLog : Entity<Guid>
{
    // EF core
    protected OutboxLog() { }

    public OutboxLog(
        SourceApp sourceApp,
        string payload,
        bool processed,
        DateTime processedAt,
        DateTime createdAt,
        DateTime updatedAt,
        DateTime? deletedAt) : base(createdAt, updatedAt, deletedAt)
    {
        SourceApp = sourceApp;
        Payload = payload;
        Processed = processed;
        ProcessedAt = processedAt;
    }
    
    public SourceApp SourceApp { get; private set; }
    public string Payload { get; private set; }
    public bool Processed { get; private set; }
    public DateTime ProcessedAt { get; private set; }
}