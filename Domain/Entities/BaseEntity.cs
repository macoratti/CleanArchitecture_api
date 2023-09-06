namespace CleanArchitecture.Domain.Entities;

public abstract class BaseEntity
{
    public Guid Id { get; set; }
    public DateTimeOffset DateCreated { get; set; }
    public DateTimeOffset? DateUpdated { get; set; }
    public DateTimeOffset? DateDeleted { get; set; }
}
