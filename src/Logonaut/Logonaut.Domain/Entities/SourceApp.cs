using Logonaut.Domain.Models.SourceApp;

namespace Logonaut.Domain.Entities;

public class SourceApp : Entity<long>
{
    // EF core
    protected SourceApp()
    {
    }

    public SourceApp(
        string name,
        bool enabled,
        DateTime createdAt,
        DateTime updatedAt,
        DateTime? deletedAt) : base(createdAt, updatedAt, deletedAt)
    {
        Name = name;
        Enabled = enabled;
    }

    public string Name { get; private set; }
    public bool Enabled { get; private set; }

    public static SourceApp CreateSourceAppModelToEntity(CreateSourceAppModel model)
        => new(
            model.Name,
            enabled: true,
            createdAt: DateTime.Now,
            updatedAt: DateTime.Now,
            deletedAt: null);
}