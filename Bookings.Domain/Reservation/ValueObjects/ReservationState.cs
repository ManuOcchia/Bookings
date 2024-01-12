using Bookings.Domain.Reservations.Enums;

namespace Bookings.Domain.Reservations.ValueObjects;

public sealed class ReservationState : ValueObject
{
    public ReservationStates Value { get; private init; }

    private ReservationState(ReservationStates value)
    {
        Value = value;
    }

    public ReservationState From(ReservationStates value)
    {
        return new(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}

