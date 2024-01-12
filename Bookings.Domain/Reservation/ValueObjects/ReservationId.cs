namespace Bookings.Domain.Reservations.ValueObjects;

public sealed class ReservationId : EntityId
{
    private ReservationId(Guid value)
        : base(value)
    {
    }

    public ReservationId From(Guid value)
    {
        return new(value);
    }

    public static ReservationId New()
    {
        return new ReservationId(Guid.NewGuid());
    }
}
