namespace Bookings.Domain.Closings.ValueObjects;

public sealed class ClosingId : EntityId
{
    private ClosingId(Guid value)
        : base(value)
    {
    }

    public ClosingId From(Guid value)
    {
        return new(value);
    }

    public static ClosingId New()
    {
        return new ClosingId(Guid.NewGuid());
    }
}
