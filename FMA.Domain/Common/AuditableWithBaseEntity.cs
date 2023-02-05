namespace FMA.Domain.Common;

public class AuditableWithBaseEntity<T> : BaseEntity<T>, IAuditableEntity
{
    public bool IsDeleted { get; set; } = false;
    public DateTime Created { get; set; }
    public Guid CreatedId { get; set; }
    public DateTime? Modified { get; set; }
    public Guid? ModifiedId { get; set; }
}