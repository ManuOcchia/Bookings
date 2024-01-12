namespace Bookings.Domain.Reservations.ValueObjects;

public sealed class ReservationPhone : ValueObject
{
    public string Value { get; private init; }

    private ReservationPhone(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentNullException("Reservation phone cannot be empty or white space", nameof(ReservationPhone));
        }

        if (value.Length < 6)
        {
            throw new ArgumentException("Reservation phone cannot have lenght less than 6", nameof(ReservationPhone));
        }

        if (value.Length > 15)
        {
            throw new ArgumentException("Reservation phone cannot have lenght greater than 15", nameof(ReservationPhone));
        }

        Value = value;
    }

    public ReservationPhone From(string value)
    {
        return new(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}

