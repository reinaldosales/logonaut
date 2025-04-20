using Logonaut.Infra.IoC;
using Logonaut.OutboxReader;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

builder.Services.AddDatabase(builder.Configuration);

var host = builder.Build();
host.Run();