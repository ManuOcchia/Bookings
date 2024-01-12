namespace Bookings.Domain.Reservations.ValueObjects;

public sealed class ReservationName : ValueObject
{
    public string Value { get; private init; }

    private ReservationName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentNullException("Reservation name cannot be empty or white space", nameof(ReservationName));
        }

        if (value.Length < 4)
        {
            throw new ArgumentException("Reservation name cannot have lenght less than 4", nameof(ReservationName));
        }

        if (value.Length > 30)
        {
            throw new ArgumentException("Reservation name cannot have lenght greater than 30", nameof(ReservationName));
        }

        Value = value;
    }

    public ReservationName From(string value)
    {
        return new(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}

