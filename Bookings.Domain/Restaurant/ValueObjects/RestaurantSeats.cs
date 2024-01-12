namespace Bookings.Domain.Restaurants.ValueObjects;

public sealed class RestaurantSeats : ValueObject
{
    public const int MIN_VALUE = 10;
    public int Value { get; private init; }

    private RestaurantSeats(int value)
    {
        if (value < MIN_VALUE)
        {
            throw new ArgumentException($"Restaurant Seats cannot be less than {MIN_VALUE}", nameof(RestaurantSeats));
        }

        Value = value;
    }

    public RestaurantSeats From(int value)
    {
        return new(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}

