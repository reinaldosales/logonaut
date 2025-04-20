using System.ComponentModel.Design;
using Logonaut.Client.Abstractions;
using Logonaut.Client.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace Logonaut.Client;

public static class LogonautExtensions
{
    // TODO: tornar o Logonaut total plugavel sem depender de resolução de dependencias externas como services, repositories e até mesmo dbcontex (criar um LogonautDbContext que recerá connectionStrings via options).  
    // TODO: Registrar serviço automaticamente
    public static IServiceCollection AddLogonautClient(
        this IServiceCollection serviceCollection,
        Action<LogonautOpptions> configure)
    {
        var options = new LogonautOpptions();
        configure(options);
        
        serviceCollection.AddSingleton(options);
        serviceCollection.AddScoped<ILogonautLogger, LogonautLogger>();
        
        return serviceCollection;
    } 
}