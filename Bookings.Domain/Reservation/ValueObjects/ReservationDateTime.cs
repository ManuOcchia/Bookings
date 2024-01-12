namespace Bookings.Domain.Reservations.ValueObjects;

public sealed class ReservationDateTime : ValueObject
{
    public DateTime Value { get; private init; }

    private ReservationDateTime(DateTime value)
    {
        Value = value;
    }

    public ReservationDateTime From(DateTime value)
    {
        return new(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}

