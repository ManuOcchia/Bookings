namespace Bookings.Domain.Restaurants.ValueObjects;

public sealed class RestaurantName : ValueObject
{
    public string Value { get; private init; }

    private RestaurantName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentNullException("Restaurant Name cannot be empty or white space", nameof(RestaurantName));
        }

        if (value.Length < 4)
        {
            throw new ArgumentException("Restaurant Name cannot have lenght less than 4", nameof(RestaurantName));
        }

        Value = value;
    }

    public RestaurantName From(string value)
    {
        return new(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}

