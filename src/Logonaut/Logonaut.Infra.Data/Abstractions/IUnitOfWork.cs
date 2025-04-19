namespace Logonaut.Infra.Data.Abstractions;

public interface IUnitOfWork
{
    Task<int> CommitAsync();
}