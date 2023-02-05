using FMA.Domain.Common;

namespace FMA.Domain.Master;

public class AppSetting : BaseEntity<Guid>
{
    public string ReferenceKey { get; set; } = String.Empty;

    public string Value { get; set; } = String.Empty;

    public string? Description { get; set; }

    public string Type { get; set; } = String.Empty;
}