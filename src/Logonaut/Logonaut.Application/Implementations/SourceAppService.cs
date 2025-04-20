using Logonaut.Application.Abstractions;
using Logonaut.Domain.Abstractions;
using Logonaut.Domain.Entities;

namespace Logonaut.Application.Implementations;

public class SourceAppService(ISourceAppRepository sourceAppRepository) : ISourceAppService
{
    private readonly ISourceAppRepository _sourceAppRepository = sourceAppRepository;

    public Task<List<SourceApp>> GetOutboxLogsAsync()
        => _sourceAppRepository.GetOutboxLogsAsync();

    public void InsertAsync(SourceApp sourceApp)
    {
        throw new NotImplementedException();
    }
}