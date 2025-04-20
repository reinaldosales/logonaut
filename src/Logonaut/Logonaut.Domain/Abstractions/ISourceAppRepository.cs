using Logonaut.Domain.Entities;

namespace Logonaut.Domain.Abstractions;

public interface ISourceAppRepository
{
    Task<List<SourceApp>> GetOutboxLogsAsync();
    void InsertAsync(SourceApp sourceApp);
}