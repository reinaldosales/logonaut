using Logonaut.Domain.Entities;

namespace Logonaut.Application.Abstractions;

public interface ISourceAppService
{
    Task<List<SourceApp>> GetOutboxLogsAsync();
    void InsertAsync(SourceApp sourceApp);
}