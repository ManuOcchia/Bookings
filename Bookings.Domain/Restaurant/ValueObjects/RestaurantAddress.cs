namespace Bookings.Domain.Restaurants.ValueObjects;

public sealed class RestaurantAddress : ValueObject
{
    public string Country { get; private init; }
    public string State { get; private init; }
    public string City { get; private init; }
    public string Line1 { get; private init; }
    public string Line2 { get; private init; }
    public string PostalCode { get; private init; }

    private RestaurantAddress(string country, string state, string city, string line1, string line2, string postalCode)
    {
        if (string.IsNullOrWhiteSpace(country))
        {
            throw new ArgumentNullException("Restaurant Address Country cannot be empty or white space", nameof(country));
        }

        if (country.Length is not 2)
        {
            throw new ArgumentException("Restaurant Address Country must have 2 letters format", nameof(country));
        }

        if (string.IsNullOrWhiteSpace(state))
        {
            throw new ArgumentNullException("Restaurant Address State cannot be empty or white space", nameof(state));
        }

        if (string.IsNullOrWhiteSpace(city))
        {
            throw new ArgumentNullException("Restaurant Address City cannot be empty or white space", nameof(city));
        }

        if (string.IsNullOrWhiteSpace(line1))
        {
            throw new ArgumentNullException("Restaurant Address Line1 cannot be empty or white space", nameof(line1));
        }

        if (string.IsNullOrWhiteSpace(postalCode))
        {
            throw new ArgumentNullException("Restaurant Address PostalCode cannot be empty or white space", nameof(postalCode));
        }

        Country = country;
        State = state;
        City = city;
        Line1 = line1;
        Line2 = line2;
        PostalCode = postalCode;
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Country;
        yield return State;
        yield return City;
        yield return Line1;
        yield return Line2;
        yield return PostalCode;
    }
}

