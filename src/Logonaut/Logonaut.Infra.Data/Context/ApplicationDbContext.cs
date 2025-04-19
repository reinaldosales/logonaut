using Logonaut.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Logonaut.Infra.Data.Context;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<OutboxLog> OutboxLogs { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
    }
}   