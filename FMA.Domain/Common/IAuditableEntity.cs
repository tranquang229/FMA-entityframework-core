namespace FMA.Domain.Common;

public interface IAuditableEntity
{
    bool IsDeleted { get; set; }

    DateTime Created { get; set; }

    Guid CreatedId { get; set; }

    DateTime? Modified { get; set; }

    Guid? ModifiedId { get; set; }
}