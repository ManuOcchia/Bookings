namespace Bookings.Domain.Reservations.ValueObjects;

public sealed class ReservationNotes : ValueObject
{
    public string Value { get; private init; }

    private ReservationNotes(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentNullException("Reservation notes cannot be empty or white space", nameof(ReservationNotes));
        }

        if (value.Length > 300)
        {
            throw new ArgumentException("Reservation notes cannot have lenght greater than 300", nameof(ReservationNotes));
        }

        Value = value;
    }

    public ReservationNotes From(string value)
    {
        return new(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}

