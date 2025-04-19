namespace Logonaut.Domain;

public class Entity<T>
{
    // EF core
    protected Entity() { }

    public Entity(DateTime createdAt, DateTime updatedAt, DateTime? deletedAt)
        => (CreatedAt, UpdatedAt, DeletedAt) = (createdAt, updatedAt, deletedAt); 

    public T Id { get; private set; }
    public DateTime CreatedAt { get; private set; }  
    public DateTime UpdatedAt { get; private set; }  
    public DateTime? DeletedAt { get; private set; }  
}