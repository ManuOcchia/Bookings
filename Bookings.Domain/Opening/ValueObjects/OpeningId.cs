namespace Bookings.Domain.Openings.ValueObjects;

public sealed class OpeningId : EntityId
{
    private OpeningId(Guid value)
        : base(value)
    {
    }

    public OpeningId From(Guid value)
    {
        return new(value);
    }

    public static OpeningId New()
    {
        return new OpeningId(Guid.NewGuid());
    }
}
