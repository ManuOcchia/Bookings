namespace Bookings.Domain.Meals.ValueObjects;

public sealed class MealAvailability : ValueObject
{
    public int Seats { get; private init; }
    public DateTime Open { get; private init; }
    public DateTime Close { get; private init; }

    private MealAvailability(int value, DateTime open, DateTime close)
    {
        Seats = value;
        Open = open;
        Close = close;
    }

    public MealAvailability From(int seats, DateTime open, DateTime close)
    {
        return new(seats, open, close);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Seats;
        yield return Open;
        yield return Close;
    }
}

