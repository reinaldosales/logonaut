using Logonaut.Domain.Entities;

namespace Logonaut.Client.Abstractions;

public interface ILogonautLogger
{
    public Task LogAsync(string payload);
}