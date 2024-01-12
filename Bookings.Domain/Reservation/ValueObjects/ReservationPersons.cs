namespace Bookings.Domain.Reservations.ValueObjects;

public sealed class ReservationPersons : ValueObject
{
    public int Value { get; private init; }

    private ReservationPersons(int value)
    {
        if (value < 1)
        {
            throw new ArgumentException("Reservation persons must be greater than 0", nameof(ReservationPersons));
        }

        Value = value;
    }

    public ReservationPersons From(int value)
    {
        return new(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}

