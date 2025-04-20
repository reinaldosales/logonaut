using Logonaut.Domain.Entities;

namespace Logonaut.Client;

public class LogonautOpptions
{
    public string SourceApp { get; set; } = null!;
    
    // TODO: Implementar registro automatico de app posteriormente (tornar util entidade SourceApp)
    public bool AutoRegisterSourceApp { get; set; } = true;
}