using Logonaut.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Logonaut.Infra.Data.ContextMappers;

public class OutboxLogMap : IEntityTypeConfiguration<OutboxLog>
{
    public void Configure(EntityTypeBuilder<OutboxLog> builder)
    {
        builder.ToTable("outbox_log");
        
        builder
            .Property(e => e.Payload)
            .HasColumnName("payload")
            .HasColumnType("jsonb");
    }
}